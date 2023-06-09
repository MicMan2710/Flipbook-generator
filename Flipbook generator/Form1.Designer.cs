﻿
namespace Flipbook_generator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.tpSingle = new System.Windows.Forms.TabPage();
            this.lblWait = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbOptionsSingle = new System.Windows.Forms.GroupBox();
            this.cbOnlyLast = new System.Windows.Forms.CheckBox();
            this.cbDistraction = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSplits = new System.Windows.Forms.TextBox();
            this.cbShare = new System.Windows.Forms.CheckBox();
            this.cbLogo = new System.Windows.Forms.CheckBox();
            this.gbImportSingle = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblWaitBulk = new System.Windows.Forms.Label();
            this.btnExports = new System.Windows.Forms.Button();
            this.gbOptionsBulk = new System.Windows.Forms.GroupBox();
            this.cbDistractions = new System.Windows.Forms.CheckBox();
            this.cbShares = new System.Windows.Forms.CheckBox();
            this.cbShowLogos = new System.Windows.Forms.CheckBox();
            this.gbImports = new System.Windows.Forms.GroupBox();
            this.lblFiles = new System.Windows.Forms.Label();
            this.btnLoadFiles = new System.Windows.Forms.Button();
            this.tpHelp = new System.Windows.Forms.TabPage();
            this.lvlVer = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.openFileDia = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDia = new System.Windows.Forms.SaveFileDialog();
            this.gbOrientSingle = new System.Windows.Forms.GroupBox();
            this.rbPortrait_S = new System.Windows.Forms.RadioButton();
            this.rbLandscape_S = new System.Windows.Forms.RadioButton();
            this.rbLandscape_B = new System.Windows.Forms.RadioButton();
            this.rbPortrait_B = new System.Windows.Forms.RadioButton();
            this.gbOrient_B = new System.Windows.Forms.GroupBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.tcTabs.SuspendLayout();
            this.tpSingle.SuspendLayout();
            this.gbOptionsSingle.SuspendLayout();
            this.gbImportSingle.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbOptionsBulk.SuspendLayout();
            this.gbImports.SuspendLayout();
            this.tpHelp.SuspendLayout();
            this.gbOrientSingle.SuspendLayout();
            this.gbOrient_B.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tcTabs
            // 
            this.tcTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcTabs.Controls.Add(this.tpSingle);
            this.tcTabs.Controls.Add(this.tabPage2);
            this.tcTabs.Controls.Add(this.tpHelp);
            this.tcTabs.Location = new System.Drawing.Point(12, 12);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(505, 352);
            this.tcTabs.TabIndex = 0;
            // 
            // tpSingle
            // 
            this.tpSingle.Controls.Add(this.lblWait);
            this.tpSingle.Controls.Add(this.btnSave);
            this.tpSingle.Controls.Add(this.gbOptionsSingle);
            this.tpSingle.Controls.Add(this.gbImportSingle);
            this.tpSingle.Location = new System.Drawing.Point(4, 22);
            this.tpSingle.Name = "tpSingle";
            this.tpSingle.Padding = new System.Windows.Forms.Padding(3);
            this.tpSingle.Size = new System.Drawing.Size(497, 326);
            this.tpSingle.TabIndex = 0;
            this.tpSingle.Text = "Single file export";
            this.tpSingle.UseVisualStyleBackColor = true;
            // 
            // lblWait
            // 
            this.lblWait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWait.AutoSize = true;
            this.lblWait.Location = new System.Drawing.Point(9, 302);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(10, 13);
            this.lblWait.TabIndex = 3;
            this.lblWait.Text = ".";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(374, 297);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(117, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Export Package";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbOptionsSingle
            // 
            this.gbOptionsSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOptionsSingle.Controls.Add(this.gbOrientSingle);
            this.gbOptionsSingle.Controls.Add(this.cbOnlyLast);
            this.gbOptionsSingle.Controls.Add(this.cbDistraction);
            this.gbOptionsSingle.Controls.Add(this.label1);
            this.gbOptionsSingle.Controls.Add(this.txtSplits);
            this.gbOptionsSingle.Controls.Add(this.cbShare);
            this.gbOptionsSingle.Controls.Add(this.cbLogo);
            this.gbOptionsSingle.Location = new System.Drawing.Point(6, 71);
            this.gbOptionsSingle.Name = "gbOptionsSingle";
            this.gbOptionsSingle.Size = new System.Drawing.Size(485, 220);
            this.gbOptionsSingle.TabIndex = 1;
            this.gbOptionsSingle.TabStop = false;
            this.gbOptionsSingle.Text = "Options";
            // 
            // cbOnlyLast
            // 
            this.cbOnlyLast.AutoSize = true;
            this.cbOnlyLast.Location = new System.Drawing.Point(6, 117);
            this.cbOnlyLast.Name = "cbOnlyLast";
            this.cbOnlyLast.Size = new System.Drawing.Size(336, 17);
            this.cbOnlyLast.TabIndex = 5;
            this.cbOnlyLast.Text = "Only add distraction to last split (Only applies when splits are used)";
            this.cbOnlyLast.UseVisualStyleBackColor = true;
            // 
            // cbDistraction
            // 
            this.cbDistraction.AutoSize = true;
            this.cbDistraction.Checked = true;
            this.cbDistraction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDistraction.Location = new System.Drawing.Point(6, 94);
            this.cbDistraction.Name = "cbDistraction";
            this.cbDistraction.Size = new System.Drawing.Size(158, 17);
            this.cbDistraction.TabIndex = 4;
            this.cbDistraction.Text = "Add distraction to flipbook/s";
            this.cbDistraction.UseVisualStyleBackColor = true;
            this.cbDistraction.CheckedChanged += new System.EventHandler(this.cbDistraction_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Split flipbook after pages. Eg. (2,5,10)";
            // 
            // txtSplits
            // 
            this.txtSplits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSplits.Location = new System.Drawing.Point(196, 65);
            this.txtSplits.Name = "txtSplits";
            this.txtSplits.Size = new System.Drawing.Size(283, 20);
            this.txtSplits.TabIndex = 2;
            this.txtSplits.Enter += new System.EventHandler(this.txtSplits_Enter);
            this.txtSplits.Leave += new System.EventHandler(this.txtSplits_Leave);
            // 
            // cbShare
            // 
            this.cbShare.AutoSize = true;
            this.cbShare.Checked = true;
            this.cbShare.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShare.Location = new System.Drawing.Point(6, 42);
            this.cbShare.Name = "cbShare";
            this.cbShare.Size = new System.Drawing.Size(128, 17);
            this.cbShare.TabIndex = 1;
            this.cbShare.Text = "Remove share button";
            this.cbShare.UseVisualStyleBackColor = true;
            // 
            // cbLogo
            // 
            this.cbLogo.AutoSize = true;
            this.cbLogo.Checked = true;
            this.cbLogo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLogo.Location = new System.Drawing.Point(6, 19);
            this.cbLogo.Name = "cbLogo";
            this.cbLogo.Size = new System.Drawing.Size(76, 17);
            this.cbLogo.TabIndex = 0;
            this.cbLogo.Text = "Show logo";
            this.cbLogo.UseVisualStyleBackColor = true;
            // 
            // gbImportSingle
            // 
            this.gbImportSingle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbImportSingle.Controls.Add(this.btnBrowse);
            this.gbImportSingle.Controls.Add(this.txtFilePath);
            this.gbImportSingle.Location = new System.Drawing.Point(6, 6);
            this.gbImportSingle.Name = "gbImportSingle";
            this.gbImportSingle.Size = new System.Drawing.Size(485, 59);
            this.gbImportSingle.TabIndex = 0;
            this.gbImportSingle.TabStop = false;
            this.gbImportSingle.Text = "Select a PDF file";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(386, 20);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(93, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Location = new System.Drawing.Point(6, 23);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(374, 20);
            this.txtFilePath.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblWaitBulk);
            this.tabPage2.Controls.Add(this.btnExports);
            this.tabPage2.Controls.Add(this.gbOptionsBulk);
            this.tabPage2.Controls.Add(this.gbImports);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(497, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Bulk Export";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblWaitBulk
            // 
            this.lblWaitBulk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWaitBulk.AutoSize = true;
            this.lblWaitBulk.Location = new System.Drawing.Point(9, 302);
            this.lblWaitBulk.Name = "lblWaitBulk";
            this.lblWaitBulk.Size = new System.Drawing.Size(10, 13);
            this.lblWaitBulk.TabIndex = 7;
            this.lblWaitBulk.Text = ".";
            // 
            // btnExports
            // 
            this.btnExports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExports.Enabled = false;
            this.btnExports.Location = new System.Drawing.Point(374, 297);
            this.btnExports.Name = "btnExports";
            this.btnExports.Size = new System.Drawing.Size(117, 23);
            this.btnExports.TabIndex = 6;
            this.btnExports.Text = "Export Packages";
            this.btnExports.UseVisualStyleBackColor = true;
            this.btnExports.Click += new System.EventHandler(this.btnExports_Click);
            // 
            // gbOptionsBulk
            // 
            this.gbOptionsBulk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOptionsBulk.Controls.Add(this.gbOrient_B);
            this.gbOptionsBulk.Controls.Add(this.cbDistractions);
            this.gbOptionsBulk.Controls.Add(this.cbShares);
            this.gbOptionsBulk.Controls.Add(this.cbShowLogos);
            this.gbOptionsBulk.Location = new System.Drawing.Point(6, 71);
            this.gbOptionsBulk.Name = "gbOptionsBulk";
            this.gbOptionsBulk.Size = new System.Drawing.Size(485, 215);
            this.gbOptionsBulk.TabIndex = 5;
            this.gbOptionsBulk.TabStop = false;
            this.gbOptionsBulk.Text = "Options";
            // 
            // cbDistractions
            // 
            this.cbDistractions.AutoSize = true;
            this.cbDistractions.Checked = true;
            this.cbDistractions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDistractions.Location = new System.Drawing.Point(6, 65);
            this.cbDistractions.Name = "cbDistractions";
            this.cbDistractions.Size = new System.Drawing.Size(285, 17);
            this.cbDistractions.TabIndex = 5;
            this.cbDistractions.Text = "Add distractions (Each file will have another distraction)";
            this.cbDistractions.UseVisualStyleBackColor = true;
            // 
            // cbShares
            // 
            this.cbShares.AutoSize = true;
            this.cbShares.Checked = true;
            this.cbShares.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShares.Location = new System.Drawing.Point(6, 42);
            this.cbShares.Name = "cbShares";
            this.cbShares.Size = new System.Drawing.Size(128, 17);
            this.cbShares.TabIndex = 1;
            this.cbShares.Text = "Remove share button";
            this.cbShares.UseVisualStyleBackColor = true;
            // 
            // cbShowLogos
            // 
            this.cbShowLogos.AutoSize = true;
            this.cbShowLogos.Checked = true;
            this.cbShowLogos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowLogos.Location = new System.Drawing.Point(6, 19);
            this.cbShowLogos.Name = "cbShowLogos";
            this.cbShowLogos.Size = new System.Drawing.Size(76, 17);
            this.cbShowLogos.TabIndex = 0;
            this.cbShowLogos.Text = "Show logo";
            this.cbShowLogos.UseVisualStyleBackColor = true;
            // 
            // gbImports
            // 
            this.gbImports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbImports.Controls.Add(this.lblFiles);
            this.gbImports.Controls.Add(this.btnLoadFiles);
            this.gbImports.Location = new System.Drawing.Point(6, 6);
            this.gbImports.Name = "gbImports";
            this.gbImports.Size = new System.Drawing.Size(485, 59);
            this.gbImports.TabIndex = 4;
            this.gbImports.TabStop = false;
            this.gbImports.Text = "Select PDF files";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(116, 26);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(10, 13);
            this.lblFiles.TabIndex = 2;
            this.lblFiles.Text = ".";
            // 
            // btnLoadFiles
            // 
            this.btnLoadFiles.Location = new System.Drawing.Point(9, 21);
            this.btnLoadFiles.Name = "btnLoadFiles";
            this.btnLoadFiles.Size = new System.Drawing.Size(101, 23);
            this.btnLoadFiles.TabIndex = 1;
            this.btnLoadFiles.Text = "Select Files";
            this.btnLoadFiles.UseVisualStyleBackColor = true;
            this.btnLoadFiles.Click += new System.EventHandler(this.btnLoadFiles_Click);
            // 
            // tpHelp
            // 
            this.tpHelp.Controls.Add(this.Logo);
            this.tpHelp.Controls.Add(this.lvlVer);
            this.tpHelp.Controls.Add(this.lblInfo);
            this.tpHelp.Location = new System.Drawing.Point(4, 22);
            this.tpHelp.Name = "tpHelp";
            this.tpHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tpHelp.Size = new System.Drawing.Size(497, 326);
            this.tpHelp.TabIndex = 2;
            this.tpHelp.Text = "Info";
            this.tpHelp.UseVisualStyleBackColor = true;
            // 
            // lvlVer
            // 
            this.lvlVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lvlVer.AutoSize = true;
            this.lvlVer.Location = new System.Drawing.Point(444, 310);
            this.lvlVer.Name = "lvlVer";
            this.lvlVer.Size = new System.Drawing.Size(47, 13);
            this.lvlVer.TabIndex = 1;
            this.lvlVer.Text = "Ver 1.04";
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.Location = new System.Drawing.Point(6, 3);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(485, 208);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // openFileDia
            // 
            this.openFileDia.FileName = "openFileDialog1";
            this.openFileDia.Filter = "PDF|*.pdf";
            // 
            // saveFileDia
            // 
            this.saveFileDia.Filter = "ZIP|*.zip";
            // 
            // gbOrientSingle
            // 
            this.gbOrientSingle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOrientSingle.Controls.Add(this.rbLandscape_S);
            this.gbOrientSingle.Controls.Add(this.rbPortrait_S);
            this.gbOrientSingle.Location = new System.Drawing.Point(6, 140);
            this.gbOrientSingle.Name = "gbOrientSingle";
            this.gbOrientSingle.Size = new System.Drawing.Size(473, 74);
            this.gbOrientSingle.TabIndex = 6;
            this.gbOrientSingle.TabStop = false;
            this.gbOrientSingle.Text = "Page Orientation";
            // 
            // rbPortrait_S
            // 
            this.rbPortrait_S.AutoSize = true;
            this.rbPortrait_S.Checked = true;
            this.rbPortrait_S.Location = new System.Drawing.Point(6, 19);
            this.rbPortrait_S.Name = "rbPortrait_S";
            this.rbPortrait_S.Size = new System.Drawing.Size(58, 17);
            this.rbPortrait_S.TabIndex = 0;
            this.rbPortrait_S.TabStop = true;
            this.rbPortrait_S.Text = "Portrait";
            this.rbPortrait_S.UseVisualStyleBackColor = true;
            // 
            // rbLandscape_S
            // 
            this.rbLandscape_S.AutoSize = true;
            this.rbLandscape_S.Location = new System.Drawing.Point(6, 42);
            this.rbLandscape_S.Name = "rbLandscape_S";
            this.rbLandscape_S.Size = new System.Drawing.Size(78, 17);
            this.rbLandscape_S.TabIndex = 1;
            this.rbLandscape_S.TabStop = true;
            this.rbLandscape_S.Text = "Landscape";
            this.rbLandscape_S.UseVisualStyleBackColor = true;
            // 
            // rbLandscape_B
            // 
            this.rbLandscape_B.AutoSize = true;
            this.rbLandscape_B.Location = new System.Drawing.Point(6, 42);
            this.rbLandscape_B.Name = "rbLandscape_B";
            this.rbLandscape_B.Size = new System.Drawing.Size(78, 17);
            this.rbLandscape_B.TabIndex = 1;
            this.rbLandscape_B.TabStop = true;
            this.rbLandscape_B.Text = "Landscape";
            this.rbLandscape_B.UseVisualStyleBackColor = true;
            // 
            // rbPortrait_B
            // 
            this.rbPortrait_B.AutoSize = true;
            this.rbPortrait_B.Checked = true;
            this.rbPortrait_B.Location = new System.Drawing.Point(6, 19);
            this.rbPortrait_B.Name = "rbPortrait_B";
            this.rbPortrait_B.Size = new System.Drawing.Size(58, 17);
            this.rbPortrait_B.TabIndex = 0;
            this.rbPortrait_B.TabStop = true;
            this.rbPortrait_B.Text = "Portrait";
            this.rbPortrait_B.UseVisualStyleBackColor = true;
            // 
            // gbOrient_B
            // 
            this.gbOrient_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOrient_B.Controls.Add(this.rbLandscape_B);
            this.gbOrient_B.Controls.Add(this.rbPortrait_B);
            this.gbOrient_B.Location = new System.Drawing.Point(6, 88);
            this.gbOrient_B.Name = "gbOrient_B";
            this.gbOrient_B.Size = new System.Drawing.Size(473, 121);
            this.gbOrient_B.TabIndex = 7;
            this.gbOrient_B.TabStop = false;
            this.gbOrient_B.Text = "Page Orientation";
            // 
            // Logo
            // 
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Logo.Image = global::Flipbook_generator.Properties.Resources.DEKRA_Institute_of_Learning_;
            this.Logo.Location = new System.Drawing.Point(6, 214);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(284, 106);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 376);
            this.Controls.Add(this.tcTabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(545, 415);
            this.Name = "frmMain";
            this.Text = "Flipbook generator";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.tcTabs.ResumeLayout(false);
            this.tpSingle.ResumeLayout(false);
            this.tpSingle.PerformLayout();
            this.gbOptionsSingle.ResumeLayout(false);
            this.gbOptionsSingle.PerformLayout();
            this.gbImportSingle.ResumeLayout(false);
            this.gbImportSingle.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gbOptionsBulk.ResumeLayout(false);
            this.gbOptionsBulk.PerformLayout();
            this.gbImports.ResumeLayout(false);
            this.gbImports.PerformLayout();
            this.tpHelp.ResumeLayout(false);
            this.tpHelp.PerformLayout();
            this.gbOrientSingle.ResumeLayout(false);
            this.gbOrientSingle.PerformLayout();
            this.gbOrient_B.ResumeLayout(false);
            this.gbOrient_B.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTabs;
        private System.Windows.Forms.TabPage tpSingle;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbImportSingle;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbOptionsSingle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSplits;
        private System.Windows.Forms.CheckBox cbShare;
        private System.Windows.Forms.CheckBox cbLogo;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.OpenFileDialog openFileDia;
        private System.Windows.Forms.SaveFileDialog saveFileDia;
        private System.Windows.Forms.Label lblWaitBulk;
        private System.Windows.Forms.Button btnExports;
        private System.Windows.Forms.GroupBox gbOptionsBulk;
        private System.Windows.Forms.CheckBox cbShares;
        private System.Windows.Forms.CheckBox cbShowLogos;
        private System.Windows.Forms.GroupBox gbImports;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Button btnLoadFiles;
        private System.Windows.Forms.TabPage tpHelp;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.CheckBox cbDistraction;
        private System.Windows.Forms.CheckBox cbDistractions;
        private System.Windows.Forms.CheckBox cbOnlyLast;
        private System.Windows.Forms.Label lvlVer;
        private System.Windows.Forms.GroupBox gbOrientSingle;
        private System.Windows.Forms.RadioButton rbLandscape_S;
        private System.Windows.Forms.RadioButton rbPortrait_S;
        private System.Windows.Forms.GroupBox gbOrient_B;
        private System.Windows.Forms.RadioButton rbLandscape_B;
        private System.Windows.Forms.RadioButton rbPortrait_B;
        private System.Windows.Forms.PictureBox Logo;
    }
}

