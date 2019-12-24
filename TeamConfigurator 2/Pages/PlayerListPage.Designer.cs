namespace TeamConfigurator_2.Pages
{
    partial class PlayerListPage
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_LoadFromTTLive = new System.Windows.Forms.Button();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.olv_Players = new BrightIdeasSoftware.ObjectListView();
            this.col_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.col_LPZ = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olv_Players)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LoadFromTTLive
            // 
            this.btn_LoadFromTTLive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_LoadFromTTLive.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_LoadFromTTLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadFromTTLive.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_LoadFromTTLive.Location = new System.Drawing.Point(649, 4);
            this.btn_LoadFromTTLive.Name = "btn_LoadFromTTLive";
            this.btn_LoadFromTTLive.Size = new System.Drawing.Size(145, 52);
            this.btn_LoadFromTTLive.TabIndex = 1;
            this.btn_LoadFromTTLive.Text = "Load players from TT-Live";
            this.btn_LoadFromTTLive.UseVisualStyleBackColor = false;
            this.btn_LoadFromTTLive.Click += new System.EventHandler(this.btn_LoadFromTTLive_Click);
            // 
            // lbl_DateTime
            // 
            this.lbl_DateTime.AutoSize = true;
            this.lbl_DateTime.Location = new System.Drawing.Point(4, 4);
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(84, 15);
            this.lbl_DateTime.TabIndex = 3;
            this.lbl_DateTime.Text = "[Update Time]";
            // 
            // olv_Players
            // 
            this.olv_Players.AllColumns.Add(this.col_Name);
            this.olv_Players.AllColumns.Add(this.col_LPZ);
            this.olv_Players.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olv_Players.BackColor = System.Drawing.SystemColors.ControlDark;
            this.olv_Players.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.olv_Players.CellEditUseWholeCell = false;
            this.olv_Players.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Name,
            this.col_LPZ});
            this.olv_Players.Cursor = System.Windows.Forms.Cursors.Default;
            this.olv_Players.HideSelection = false;
            this.olv_Players.Location = new System.Drawing.Point(0, 56);
            this.olv_Players.Name = "olv_Players";
            this.olv_Players.Size = new System.Drawing.Size(643, 401);
            this.olv_Players.TabIndex = 4;
            this.olv_Players.UseCompatibleStateImageBehavior = false;
            this.olv_Players.View = System.Windows.Forms.View.Details;
            // 
            // col_Name
            // 
            this.col_Name.AspectName = "Name";
            this.col_Name.Text = "Name";
            this.col_Name.UseInitialLetterForGroup = true;
            this.col_Name.Width = 240;
            // 
            // col_LPZ
            // 
            this.col_LPZ.AspectName = "LPZ";
            this.col_LPZ.Text = "LPZ";
            // 
            // PlayerListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.olv_Players);
            this.Controls.Add(this.lbl_DateTime);
            this.Controls.Add(this.btn_LoadFromTTLive);
            this.Name = "PlayerListPage";
            this.Size = new System.Drawing.Size(797, 457);
            ((System.ComponentModel.ISupportInitialize)(this.olv_Players)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_LoadFromTTLive;
        private System.Windows.Forms.Label lbl_DateTime;
        private BrightIdeasSoftware.ObjectListView olv_Players;
        private BrightIdeasSoftware.OLVColumn col_Name;
        private BrightIdeasSoftware.OLVColumn col_LPZ;
    }
}
