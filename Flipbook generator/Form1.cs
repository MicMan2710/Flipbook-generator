using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flipbook_generator
{
    public partial class frmMain : Form
    {
        private List<string> distractionFiles;
        private static Random rnd = new Random();
        private string exportDir;
        public frmMain()
        {
            InitializeComponent();

            //Check and load files
            try
            {
                distractionFiles = Directory.GetFiles(@"files\distractions\").ToList();
                if (distractionFiles.Count != 9)
                {
                    throw new FileLoadException("The application is missing files to function correctly.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The application is missing files to function correctly.", "Missing files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void ExportFile(int startPage, int endPage, PdfiumViewer.IPdfDocument document, string saveFilePath, bool showLogo, bool hideShare, bool showDistraction)
        {
            int pages = endPage - startPage;
            if (showDistraction)
                pages++;

            //Delete tmp folder if exists
            if (Directory.Exists("tmp"))
                Directory.Delete("tmp", true);

            Directory.CreateDirectory("tmp");
            Directory.CreateDirectory("tmp/pages");
            Directory.CreateDirectory("tmp/img");

            try
            {
                File.Copy("files/index.html", "tmp/index.html");
                File.Copy("files/imsmanifest.xml", "tmp/imsmanifest.xml");
                File.Copy("files/img/back.jpg", "tmp/img/back.jpg");
                File.Copy("files/img/logoimg.png", "tmp/img/logoimg.png");
            }
            catch (Exception)
            {
                MessageBox.Show("There are some missing files that are required for this program to function.", "Missing files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblWait.Text = "Export Canceled.";
                return;
            }

            //Distraction page calculations
            int distractionPageNum = -1;
            string randomDistractionFile = "";
            if (showDistraction)
            {
                if (pages > 3)
                    distractionPageNum = endPage - 3;
                else
                    distractionPageNum = endPage - 1;

                endPage++;

                randomDistractionFile = distractionFiles[rnd.Next(0, distractionFiles.Count)];
                
                string path = exportDir + @"\distractions.txt";
                string line = Environment.NewLine + Path.GetFileName(saveFilePath) + " : " + Path.GetFileNameWithoutExtension(randomDistractionFile);
                File.AppendAllText(path, line);
            }


            //export page imgs
            bool afterDistractionPage = false;
            int index;
            List<string> pageFiles = new List<string>();
            for (int i = startPage; i < endPage; i++)
            {
                if (afterDistractionPage)
                    index = i - 1;
                else
                    index = i;
                
                if (i == distractionPageNum)
                {
                    pageFiles.Add(@"pages\page" + (i + 1).ToString() + ".gif");
                    File.Copy(randomDistractionFile, "tmp/pages/page" + (i+1).ToString() + ".gif");
                    afterDistractionPage = true;
                }
                else
                {
                    var image = document.Render(index, 1000, 1413, 300, 300, true);
                    pageFiles.Add(@"pages\page" + (i + 1).ToString() + ".jpg");
                    image.Save(@"tmp/pages/page" + (i + 1).ToString() + ".jpg", ImageFormat.Jpeg);
                }
            }

            StreamReader reader = new StreamReader(File.OpenRead("tmp/index.html"));
            string fileContent = reader.ReadToEnd();
            reader.Close();
            reader.Dispose();

            //remove logo
            if (!showLogo)
                fileContent = fileContent.Replace(@"<img src='img\logo.png' style='position:absolute;left:15px;bottom:15px;z-index:100;height:auto;width:auto;max-width:16%;max-height:19%;'>", "");

            //remove share btn
            if (hideShare)
                fileContent = fileContent.Replace(@"setTimeout(function(){$('#at-expanding-share-button').hide();},2000); //This", "");

            //Add number of pages
            fileContent = fileContent.Replace("numPages: 1", "numPages: " + pages.ToString());

            //Add individual pages to code
            string pagedata = "";
            int count = 0;
            for (int i = startPage; i < endPage; i++)
            {
                count++;
                pagedata += @"<meta class='page_data' page=" + count.ToString() + @" content='" + pageFiles[count-1] + "' />" + Environment.NewLine;
            }

            fileContent = fileContent.Replace("<!-- Page data here -->", pagedata);

            StreamWriter writer = new StreamWriter(File.OpenWrite("tmp/index.html"));
            writer.Write(fileContent);
            writer.Close();
            writer.Dispose();

            if (File.Exists(saveFilePath))
                File.Delete(saveFilePath);

            ZipFile.CreateFromDirectory("tmp", saveFilePath);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDia.Multiselect = false;
            if (openFileDia.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDia.FileName;
            }
        }

        private void txtSplits_Leave(object sender, EventArgs e)
        {
            List<int> nums;
            try
            {
                nums = txtSplits.Text.Split(',')?.Select(Int32.Parse)?.ToList();
            }
            catch (Exception)
            {
                txtSplits.ForeColor = Color.Red;
                return;
            }

            foreach (var num in nums)
            {
                if (num < 1)
                {
                    txtSplits.ForeColor = Color.Red;
                    return;
                }
            }

            if (nums.Count != nums.Distinct().Count())
                txtSplits.ForeColor = Color.Red;
        }

        private void txtSplits_Enter(object sender, EventArgs e)
        {
            txtSplits.ForeColor = Color.Black;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //delete tmp folder if exists
            if (Directory.Exists("tmp"))
                Directory.Delete("tmp", true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            lblWait.Text = "Please wait. File export in progress...";

            //File exists
            Application.DoEvents();
            if (!File.Exists(txtFilePath.Text))
            {
                MessageBox.Show("The pdf file could not be found.", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblWait.Text = "Export Canceled.";
                return;
            }

            //Load pdf
            int pages;
            PdfiumViewer.PdfDocument document;
            try
            {
                document = PdfiumViewer.PdfDocument.Load(txtFilePath.Text);
                pages = document.PageCount;
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong while loading the PDF file. The file might be corrupt.", "PDF Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblWait.Text = "Export Canceled.";
                return;
            }


            List<int> splits;
            if (txtSplits.Text.Length > 0)
            {
                //validate splits
                try
                {
                    splits = txtSplits.Text.Split(',')?.Select(Int32.Parse)?.ToList();
                }
                catch (Exception)
                {
                    txtSplits.ForeColor = Color.Red;
                    MessageBox.Show("Please enter valad numbers for the page spits.", "Invalad number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblWait.Text = "Export Canceled.";
                    return;
                }

                foreach (int split in splits)
                {
                    if (split < 1)
                    {
                        txtSplits.ForeColor = Color.Red;
                        MessageBox.Show("Page numbers should start at 1.", "Invalad number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblWait.Text = "Export Canceled.";
                        return;
                    }

                    if (split >= pages)
                    {
                        txtSplits.ForeColor = Color.Red;
                        MessageBox.Show("There are only " + pages.ToString() + " pages in the selected PDF.", "Invalad number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblWait.Text = "Export Canceled.";
                        return;
                    }
                }

                if (splits.Count != splits.Distinct().Count())
                {
                    txtSplits.ForeColor = Color.Red;
                    MessageBox.Show("Please do not enter duplicate page numbers.", "Invalad number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblWait.Text = "Export Canceled.";
                    return;
                }

                //folder picker
                CommonOpenFileDialog dialog = new CommonOpenFileDialog();
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                dialog.IsFolderPicker = true;
                if (dialog.ShowDialog() != CommonFileDialogResult.Ok)
                {
                    lblWait.Text = "Export Canceled.";
                    return;
                }
                exportDir = dialog.FileName;

                //Delete distractions.txt
                if (File.Exists(dialog.FileName + @"\distractions.txt"))
                    File.Delete(dialog.FileName + @"\distractions.txt");

                //export files
                string filename = Path.GetFileNameWithoutExtension(txtFilePath.Text)+".zip";
                splits.Sort();
                for (int i = 0; i < splits.Count+1; i++)
                {
                    if (i == 0) //if first split
                    {
                        ExportFile(0, splits[i], document, dialog.FileName + @"\(1)" + filename, cbLogo.Checked, cbShare.Checked, cbDistraction.Checked && (cbOnlyLast.Checked == false));
                    }
                    else if (i == splits.Count) //if last split
                    {
                        ExportFile(splits[i - 1], pages, document, dialog.FileName + @"\(" + (i + 1).ToString() + ")" + filename, cbLogo.Checked, cbShare.Checked, cbDistraction.Checked);
                    }
                    else //if middle split
                    {
                        ExportFile(splits[i - 1], splits[i], document, dialog.FileName + @"\(" + (i + 1).ToString() + ")" + filename, cbLogo.Checked, cbShare.Checked, cbDistraction.Checked && (cbOnlyLast.Checked==false));
                    }
                }  
            }
            else
            {
                //single file export
                string savePath = "";
                if (saveFileDia.ShowDialog() == DialogResult.OK)
                {
                    savePath = saveFileDia.FileName;
                    exportDir = Directory.GetParent(savePath).FullName;

                    //Delete distractions.txt
                    if (File.Exists(exportDir + @"\distractions.txt"))
                        File.Delete(exportDir + @"\distractions.txt");
                }  
                else
                {
                    lblWait.Text = "Export Canceled.";
                    return;
                }

                ExportFile(0, pages, document, savePath, cbLogo.Checked, cbShare.Checked, cbDistraction.Checked);
            }



            lblWait.Text = "Export Completed.";
            SystemSounds.Beep.Play();
        }

        private List<string> pdfFiles;
        private void btnLoadFiles_Click(object sender, EventArgs e)
        {
            openFileDia.Multiselect = true;
            if (openFileDia.ShowDialog() == DialogResult.OK)
            {
                pdfFiles = openFileDia.FileNames.ToList();
                lblFiles.Text = pdfFiles.Count.ToString() + " files selected.";
                btnExports.Enabled = true;
            }
        }

        private void btnExports_Click(object sender, EventArgs e)
        {
            lblWaitBulk.Text = "Please wait. File export in progress...";
            Application.DoEvents();
            
            //Check selected files
            if (pdfFiles.Count == 0 || pdfFiles == null)
            {
                MessageBox.Show("There are no selected PDF files to export.", "No files", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //folder picker
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            dialog.IsFolderPicker = true;            
            if (dialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                lblWaitBulk.Text = "Export Canceled.";
                return;
            }
            exportDir = dialog.FileName;

            //Delete distractions.txt
            if (File.Exists(dialog.FileName + @"\distractions.txt"))
                File.Delete(dialog.FileName + @"\distractions.txt");

            //Files exist
            foreach (string file in pdfFiles)
            {
                if (!File.Exists(file))
                {
                    MessageBox.Show("The pdf file " + file + " could not be found.", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblWaitBulk.Text = "Export Canceled.";
                    return;
                }
            }

            int count = 0;
            foreach (string file in pdfFiles)
            {
                count++;
                lblWaitBulk.Text = "Please wait. Exporting file " + count.ToString() + " of " + pdfFiles.Count.ToString();
                Application.DoEvents();

                //Load pdf
                int pages;
                PdfiumViewer.PdfDocument document;
                try
                {
                    document = PdfiumViewer.PdfDocument.Load(file);
                    pages = document.PageCount;
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong while loading the PDF file. The file might be corrupt.", "PDF Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblWaitBulk.Text = "Export Canceled.";
                    return;
                }

                string exportFile = dialog.FileName + @"\" + Path.GetFileNameWithoutExtension(file) + ".zip";
                ExportFile(0, pages, document, exportFile, cbShowLogos.Checked, cbShare.Checked, cbDistractions.Checked);
            }

            lblWaitBulk.Text = "Export Completed.";
            SystemSounds.Beep.Play();
        }

        private void cbDistraction_CheckedChanged(object sender, EventArgs e)
        {
            cbOnlyLast.Enabled = cbDistraction.Checked;
        }
    }
}
