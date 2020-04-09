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
            this.navigation1 = new TeamConfigurator_2.Controls.Navigation();
            this.panel_PagePanel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel_PagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigation1
            // 
            this.navigation1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.navigation1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navigation1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigation1.Location = new System.Drawing.Point(0, 0);
            this.navigation1.Name = "navigation1";
            this.navigation1.Size = new System.Drawing.Size(187, 648);
            this.navigation1.TabIndex = 0;
            // 
            // panel_PagePanel
            // 
            this.panel_PagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_PagePanel.Controls.Add(this.tabPage1);
            this.panel_PagePanel.Controls.Add(this.tabPage2);
            this.panel_PagePanel.HotTrack = true;
            this.panel_PagePanel.Location = new System.Drawing.Point(189, 0);
            this.panel_PagePanel.Multiline = true;
            this.panel_PagePanel.Name = "panel_PagePanel";
            this.panel_PagePanel.SelectedIndex = 0;
            this.panel_PagePanel.ShowToolTips = true;
            this.panel_PagePanel.Size = new System.Drawing.Size(977, 648);
            this.panel_PagePanel.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(969, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(969, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_PagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Navigation navigation1;
        private System.Windows.Forms.TabControl panel_PagePanel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

