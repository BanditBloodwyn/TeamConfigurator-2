namespace TeamConfigurator_2
{
    partial class MainPage
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_PagePanel = new System.Windows.Forms.Panel();
            this.navigation1 = new TeamConfigurator_2.Controls.Navigation();
            this.SuspendLayout();
            // 
            // panel_PagePanel
            // 
            this.panel_PagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_PagePanel.BackColor = System.Drawing.Color.Transparent;
            this.panel_PagePanel.Location = new System.Drawing.Point(183, 0);
            this.panel_PagePanel.Name = "panel_PagePanel";
            this.panel_PagePanel.Size = new System.Drawing.Size(983, 648);
            this.panel_PagePanel.TabIndex = 1;
            // 
            // navigation1
            // 
            this.navigation1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navigation1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navigation1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigation1.Location = new System.Drawing.Point(0, 0);
            this.navigation1.Name = "navigation1";
            this.navigation1.Size = new System.Drawing.Size(183, 648);
            this.navigation1.TabIndex = 0;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 648);
            this.Controls.Add(this.panel_PagePanel);
            this.Controls.Add(this.navigation1);
            this.Name = "MainPage";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Navigation navigation1;
        private System.Windows.Forms.Panel panel_PagePanel;
    }
}

