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
            this.listView1 = new System.Windows.Forms.ListView();
            this.column_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_LPZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_DateTime = new System.Windows.Forms.Label();
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
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_Name,
            this.column_LPZ});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(0, 56);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(643, 401);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // column_Name
            // 
            this.column_Name.Text = "Name";
            this.column_Name.Width = 240;
            // 
            // column_LPZ
            // 
            this.column_LPZ.Text = "LPZ";
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
            // PlayerListPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.lbl_DateTime);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_LoadFromTTLive);
            this.Name = "PlayerListPage";
            this.Size = new System.Drawing.Size(797, 457);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_LoadFromTTLive;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader column_Name;
        private System.Windows.Forms.ColumnHeader column_LPZ;
        private System.Windows.Forms.Label lbl_DateTime;
    }
}
