﻿namespace mRemoteNG.UI.Forms.CredentialManager
{
    sealed partial class CredentialRepositoryTypeSelectionPage
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
            this.components = new System.ComponentModel.Container();
            this.buttonContinue = new mRemoteNG.UI.Controls.MrngButton();
            this.objectListView = new mRemoteNG.UI.Controls.MrngListView();
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.buttonBack = new mRemoteNG.UI.Controls.MrngButton();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonContinue
            // 
            this.buttonContinue._mice = mRemoteNG.UI.Controls.MrngButton.MouseState.HOVER;
            this.buttonContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonContinue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonContinue.Location = new System.Drawing.Point(314, 305);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(100, 24);
            this.buttonContinue.TabIndex = 4;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // objectListView
            // 
            this.objectListView.AllColumns.Add(this.olvColumnName);
            this.objectListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.objectListView.CellEditUseWholeCell = false;
            this.objectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnName});
            this.objectListView.CopySelectionOnControlC = false;
            this.objectListView.CopySelectionOnControlCUsesDragSource = false;
            this.objectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListView.DecorateLines = true;
            this.objectListView.FullRowSelect = true;
            this.objectListView.HasCollapsibleGroups = false;
            this.objectListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.objectListView.HideSelection = false;
            this.objectListView.LargeImageList = this.imageListLarge;
            this.objectListView.Location = new System.Drawing.Point(0, 0);
            this.objectListView.MultiSelect = false;
            this.objectListView.Name = "objectListView";
            this.objectListView.SelectAllOnControlA = false;
            this.objectListView.SelectColumnsOnRightClick = false;
            this.objectListView.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.objectListView.ShowFilterMenuOnRightClick = false;
            this.objectListView.ShowHeaderInAllViews = false;
            this.objectListView.Size = new System.Drawing.Size(422, 297);
            this.objectListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.objectListView.TabIndex = 5;
            this.objectListView.UseCompatibleStateImageBehavior = false;
            this.objectListView.View = System.Windows.Forms.View.LargeIcon;
            // 
            // olvColumnName
            // 
            this.olvColumnName.AspectName = "Text";
            this.olvColumnName.FillsFreeSpace = true;
            this.olvColumnName.Groupable = false;
            this.olvColumnName.ImageAspectName = "";
            this.olvColumnName.IsEditable = false;
            this.olvColumnName.Searchable = false;
            this.olvColumnName.ShowTextInHeader = false;
            // 
            // imageListLarge
            // 
            this.imageListLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // buttonBack
            // 
            this.buttonBack._mice = mRemoteNG.UI.Controls.MrngButton.MouseState.HOVER;
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBack.Location = new System.Drawing.Point(208, 305);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 24);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // CredentialRepositoryTypeSelectionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.objectListView);
            this.Controls.Add(this.buttonContinue);
            this.Name = "CredentialRepositoryTypeSelectionPage";
            this.Size = new System.Drawing.Size(422, 338);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       private Controls.MrngButton buttonContinue;
        private Controls.MrngListView objectListView;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private System.Windows.Forms.ImageList imageListLarge;
       private Controls.MrngButton buttonBack;
    }
}
