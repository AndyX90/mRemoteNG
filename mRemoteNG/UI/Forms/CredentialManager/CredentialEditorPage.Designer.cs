﻿namespace mRemoteNG.UI.Forms.CredentialManager
{
    sealed partial class CredentialEditorPage
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
            this.labelId = new mRemoteNG.UI.Controls.MrngLabel();
            this.textBoxId = new mRemoteNG.UI.Controls.MrngTextBox();
            this.buttonCancel = new mRemoteNG.UI.Controls.MrngButton();
            this.buttonSave = new mRemoteNG.UI.Controls.MrngButton();
            this.labelPassword = new mRemoteNG.UI.Controls.MrngLabel();
            this.textBoxPassword = new mRemoteNG.UI.Controls.SecureTextBox();
            this.labelDomain = new mRemoteNG.UI.Controls.MrngLabel();
            this.textBoxDomain = new mRemoteNG.UI.Controls.MrngTextBox();
            this.labelUsername = new mRemoteNG.UI.Controls.MrngLabel();
            this.textBoxUsername = new mRemoteNG.UI.Controls.MrngTextBox();
            this.labelTitle = new mRemoteNG.UI.Controls.MrngLabel();
            this.textBoxTitle = new mRemoteNG.UI.Controls.MrngTextBox();
            this.labelRepositoryName = new mRemoteNG.UI.Controls.MrngLabel();
            this.comboBoxRepository = new mRemoteNG.UI.Controls.MrngComboBox();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(3, 35);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(17, 13);
            this.labelId.TabIndex = 23;
            this.labelId.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxId.Location = new System.Drawing.Point(89, 35);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(208, 22);
            this.textBoxId.TabIndex = 22;
            // 
            // buttonCancel
            // 
            this.buttonCancel._mice = mRemoteNG.UI.Controls.MrngButton.MouseState.HOVER;
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(191, 167);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 24);
            this.buttonCancel.TabIndex = 21;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave._mice = mRemoteNG.UI.Controls.MrngButton.MouseState.HOVER;
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(85, 167);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 24);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(3, 139);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 19;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(89, 139);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(208, 22);
            this.textBoxPassword.TabIndex = 18;
            // 
            // labelDomain
            // 
            this.labelDomain.AutoSize = true;
            this.labelDomain.Location = new System.Drawing.Point(3, 113);
            this.labelDomain.Name = "labelDomain";
            this.labelDomain.Size = new System.Drawing.Size(47, 13);
            this.labelDomain.TabIndex = 17;
            this.labelDomain.Text = "Domain";
            // 
            // textBoxDomain
            // 
            this.textBoxDomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDomain.Location = new System.Drawing.Point(89, 113);
            this.textBoxDomain.Name = "textBoxDomain";
            this.textBoxDomain.Size = new System.Drawing.Size(208, 22);
            this.textBoxDomain.TabIndex = 16;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(3, 87);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 15;
            this.labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsername.Location = new System.Drawing.Point(89, 87);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(208, 22);
            this.textBoxUsername.TabIndex = 14;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(3, 61);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(28, 13);
            this.labelTitle.TabIndex = 13;
            this.labelTitle.Text = "Title";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitle.Location = new System.Drawing.Point(89, 61);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(208, 22);
            this.textBoxTitle.TabIndex = 12;
            // 
            // labelRepositoryName
            // 
            this.labelRepositoryName.AutoSize = true;
            this.labelRepositoryName.Location = new System.Drawing.Point(3, 9);
            this.labelRepositoryName.Name = "labelRepositoryName";
            this.labelRepositoryName.Size = new System.Drawing.Size(62, 13);
            this.labelRepositoryName.TabIndex = 24;
            this.labelRepositoryName.Text = "Repository";
            // 
            // comboBoxRepository
            // 
            this.comboBoxRepository._mice = mRemoteNG.UI.Controls.MrngComboBox.MouseState.HOVER;
            this.comboBoxRepository.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRepository.FormattingEnabled = true;
            this.comboBoxRepository.Location = new System.Drawing.Point(89, 6);
            this.comboBoxRepository.Name = "comboBoxRepository";
            this.comboBoxRepository.Size = new System.Drawing.Size(208, 21);
            this.comboBoxRepository.TabIndex = 25;
            // 
            // CredentialEditorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxRepository);
            this.Controls.Add(this.labelRepositoryName);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelDomain);
            this.Controls.Add(this.textBoxDomain);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxTitle);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "CredentialEditorPage";
            this.Size = new System.Drawing.Size(300, 201);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MrngLabel labelId;
        private Controls.MrngTextBox textBoxId;
        private Controls.MrngButton buttonCancel;
        private Controls.MrngButton buttonSave;
        private Controls.MrngLabel labelPassword;
        private Controls.SecureTextBox textBoxPassword;
        private Controls.MrngLabel labelDomain;
        private Controls.MrngTextBox textBoxDomain;
        private Controls.MrngLabel labelUsername;
        private Controls.MrngTextBox textBoxUsername;
        private Controls.MrngLabel labelTitle;
        private Controls.MrngTextBox textBoxTitle;
        private Controls.MrngLabel labelRepositoryName;
        private Controls.MrngComboBox comboBoxRepository;
    }
}
