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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flipbook_generator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ExportFile(int startPage, int endPage, PdfiumViewer.IPdfDocument document, string saveFilePath)
        {
            int pages = endPage - startPage;

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

            //export page imgs
            for (int i = startPage; i < endPage; i++)
            {
                var image = document.Render(i, 1000, 1413, 300, 300, true);
                image.Save(@"tmp/pages/page" + (i + 1).ToString() + ".jpg", ImageFormat.Jpeg);
            }

            StreamReader reader = new StreamReader(File.OpenRead("tmp/index.html"));
            string fileContent = reader.ReadToEnd();
            reader.Close();
            reader.Dispose();

            //remove logo
            if (!cbLogo.Checked)
                fileContent = fileContent.Replace(@"<img src='img\logo.png' style='position:absolute;left:15px;bottom:15px;z-index:100;height:auto;width:auto;max-width:16%;max-height:19%;'>", "");

            //remove share btn
            if (!cbShare.Checked)
                fileContent = fileContent.Replace(@"setTimeout(function(){$('#at-expanding-share-button').hide();},2000); //This", "");

            //Add number of pages
            fileContent = fileContent.Replace("numPages: 1", "numPages: " + pages.ToString());

            //Add individual pages
            string pagedata = "";
            for (int i = 0; i < pages; i++)
            {
                string pageNum = (i + 1).ToString();
                pagedata += @"<meta class='page_data' page=" + pageNum + @" content='pages\page" + pageNum + ".jpg' />" + Environment.NewLine;
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
            //File exists
            lblWait.Text = "Please wait. File export in progress...";
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
                    return;
                }

                foreach (int split in splits)
                {
                    if (split < 1)
                    {
                        txtSplits.ForeColor = Color.Red;
                        MessageBox.Show("Page numbers should start at 1.", "Invalad number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (split >= pages)
                    {
                        txtSplits.ForeColor = Color.Red;
                        MessageBox.Show("There are only " + pages.ToString() + " pages in the selected PDF.", "Invalad number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (splits.Count != splits.Distinct().Count())
                {
                    txtSplits.ForeColor = Color.Red;
                    MessageBox.Show("Please do not enter duplicate page numbers.", "Invalad number", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(dialog.FileName);
                //export files
                //splits.Sort();
                //for (int i = 0; i < splits.Count; i++)
                //{
                //    if (i == 0)
                //        ExportFile(0, splits[i], document, dialog.FileName);
                //    else
                //        ExportFile(splits[i - 1] + 1, splits[0], document, dialog.FileName);
                //}
            }
            else
            {
                //single file export
                string savePath = "";
                if (saveFileDia.ShowDialog() == DialogResult.OK)
                    savePath = saveFileDia.FileName;
                else
                {
                    lblWait.Text = "Export Canceled.";
                    return;
                }

                ExportFile(0, pages, document, savePath);
            }



            lblWait.Text = "Export Completed.";
        }
    }
}
