﻿namespace mRemoteNG.UI.Forms.CredentialManager.RepoProviders.Xml
{
    partial class XmlCredentialRepositoryEditorPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelPageTitle = new Controls.MrngLabel();
            this.buttonBrowseFiles = new Controls.MrngButton();
            this.labelFilePath = new Controls.MrngLabel();
            this.textBoxFilePath = new Controls.MrngTextBox();
            this.selectFilePathDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonConfirm = new Controls.MrngButton();
            this.textBoxId = new Controls.MrngTextBox();
            this.labelId = new Controls.MrngLabel();
            this.buttonBack = new Controls.MrngButton();
            this.newPasswordBoxes = new mRemoteNG.UI.Controls.NewPasswordWithVerification();
            this.textBoxTitle = new Controls.MrngTextBox();
            this.labelTitle = new Controls.MrngLabel();
            this.SuspendLayout();
            // 
            // labelPageTitle
            // 
            this.labelPageTitle.AutoSize = true;
            this.labelPageTitle.Location = new System.Drawing.Point(29, 6);
            this.labelPageTitle.Name = "labelPageTitle";
            this.labelPageTitle.Size = new System.Drawing.Size(132, 13);
            this.labelPageTitle.TabIndex = 0;
            this.labelPageTitle.Text = "XML Credential Repository";
            // 
            // buttonBrowseFiles
            // 
            this.buttonBrowseFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseFiles.Location = new System.Drawing.Point(276, 166);
            this.buttonBrowseFiles.Name = "buttonBrowseFiles";
            this.buttonBrowseFiles.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseFiles.TabIndex = 1;
            this.buttonBrowseFiles.Text = "Browse";
            this.buttonBrowseFiles.UseVisualStyleBackColor = true;
            this.buttonBrowseFiles.Click += new System.EventHandler(this.buttonBrowseFiles_Click);
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(29, 124);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(48, 13);
            this.labelFilePath.TabIndex = 2;
            this.labelFilePath.Text = "File Path";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilePath.Location = new System.Drawing.Point(32, 140);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(319, 20);
            this.textBoxFilePath.TabIndex = 3;
            // 
            // selectFilePathDialog
            // 
            this.selectFilePathDialog.DefaultExt = "xml";
            this.selectFilePathDialog.Filter = "XML|*.xml";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfirm.Location = new System.Drawing.Point(266, 279);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 9;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(32, 51);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(238, 20);
            this.textBoxId.TabIndex = 10;
            this.textBoxId.TabStop = false;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(29, 35);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(18, 13);
            this.labelId.TabIndex = 11;
            this.labelId.Text = "ID";
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(185, 279);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // newPasswordBoxes
            // 
            this.newPasswordBoxes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newPasswordBoxes.Location = new System.Drawing.Point(32, 192);
            this.newPasswordBoxes.MinimumSize = new System.Drawing.Size(0, 100);
            this.newPasswordBoxes.Name = "newPasswordBoxes";
            this.newPasswordBoxes.PasswordChar = '\0';
            this.newPasswordBoxes.Size = new System.Drawing.Size(319, 100);
            this.newPasswordBoxes.TabIndex = 13;
            this.newPasswordBoxes.UseSystemPasswordChar = true;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitle.Location = new System.Drawing.Point(32, 97);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(319, 20);
            this.textBoxTitle.TabIndex = 15;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(29, 81);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "Title";
            // 
            // XmlCredentialRepositoryEditorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.labelFilePath);
            this.Controls.Add(this.buttonBrowseFiles);
            this.Controls.Add(this.labelPageTitle);
            this.Controls.Add(this.newPasswordBoxes);
            this.MinimumSize = new System.Drawing.Size(300, 260);
            this.Name = "XmlCredentialRepositoryEditorPage";
            this.Size = new System.Drawing.Size(354, 305);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MrngLabel labelPageTitle;
        private Controls.MrngButton buttonBrowseFiles;
        private Controls.MrngLabel labelFilePath;
        private Controls.MrngTextBox textBoxFilePath;
        private System.Windows.Forms.SaveFileDialog selectFilePathDialog;
        private Controls.MrngButton buttonConfirm;
        private Controls.MrngTextBox textBoxId;
        private Controls.MrngLabel labelId;
        private Controls.MrngButton buttonBack;
        private Controls.NewPasswordWithVerification newPasswordBoxes;
        private Controls.MrngTextBox textBoxTitle;
        private Controls.MrngLabel labelTitle;
    }
}
