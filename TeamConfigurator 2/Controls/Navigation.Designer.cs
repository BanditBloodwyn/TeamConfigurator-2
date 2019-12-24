namespace TeamConfigurator_2.Controls
{
    partial class Navigation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.btn_PlayerList = new System.Windows.Forms.Button();
            this.btn_TeamList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lists";
            this.label1.Click += new System.EventHandler(this.ChangePage);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Analysis";
            this.label2.Click += new System.EventHandler(this.ChangePage);
            // 
            // lbl_Version
            // 
            this.lbl_Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Location = new System.Drawing.Point(3, 413);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(54, 15);
            this.lbl_Version.TabIndex = 10;
            this.lbl_Version.Text = "[Version]";
            // 
            // btn_PlayerList
            // 
            this.btn_PlayerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlayerList.Location = new System.Drawing.Point(0, 41);
            this.btn_PlayerList.Name = "btn_PlayerList";
            this.btn_PlayerList.Size = new System.Drawing.Size(200, 60);
            this.btn_PlayerList.TabIndex = 11;
            this.btn_PlayerList.Text = "Player List";
            this.btn_PlayerList.UseVisualStyleBackColor = true;
            this.btn_PlayerList.Click += new System.EventHandler(this.ChangePage);
            // 
            // btn_TeamList
            // 
            this.btn_TeamList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TeamList.Location = new System.Drawing.Point(0, 100);
            this.btn_TeamList.Name = "btn_TeamList";
            this.btn_TeamList.Size = new System.Drawing.Size(200, 60);
            this.btn_TeamList.TabIndex = 12;
            this.btn_TeamList.Text = "Team List";
            this.btn_TeamList.UseVisualStyleBackColor = true;
            this.btn_TeamList.Click += new System.EventHandler(this.ChangePage);
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.btn_TeamList);
            this.Controls.Add(this.btn_PlayerList);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Navigation";
            this.Size = new System.Drawing.Size(200, 436);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Button btn_PlayerList;
        private System.Windows.Forms.Button btn_TeamList;
    }
}
