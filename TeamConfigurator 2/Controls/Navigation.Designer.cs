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
            this.lbl_Players = new System.Windows.Forms.Label();
            this.lbl_Teams = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Main Navigation";
            // 
            // lbl_Players
            // 
            this.lbl_Players.AutoSize = true;
            this.lbl_Players.Location = new System.Drawing.Point(40, 80);
            this.lbl_Players.Name = "lbl_Players";
            this.lbl_Players.Size = new System.Drawing.Size(41, 13);
            this.lbl_Players.TabIndex = 7;
            this.lbl_Players.Text = "Players";
            // 
            // lbl_Teams
            // 
            this.lbl_Teams.AutoSize = true;
            this.lbl_Teams.Location = new System.Drawing.Point(40, 100);
            this.lbl_Teams.Name = "lbl_Teams";
            this.lbl_Teams.Size = new System.Drawing.Size(39, 13);
            this.lbl_Teams.TabIndex = 8;
            this.lbl_Teams.Text = "Teams";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Analysis";
            // 
            // lbl_Version
            // 
            this.lbl_Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Location = new System.Drawing.Point(3, 413);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(48, 13);
            this.lbl_Version.TabIndex = 10;
            this.lbl_Version.Text = "[Version]";
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Teams);
            this.Controls.Add(this.lbl_Players);
            this.Controls.Add(this.label1);
            this.Name = "Navigation";
            this.Size = new System.Drawing.Size(200, 436);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Players;
        private System.Windows.Forms.Label lbl_Teams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Version;
    }
}
