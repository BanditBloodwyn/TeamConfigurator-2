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
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.btn_PlayerList = new System.Windows.Forms.Button();
            this.btn_TeamList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BuildTeam = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lists";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.ChangePage);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Analysis";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.ChangePage);
            // 
            // lbl_Version
            // 
            this.lbl_Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Version.AutoSize = true;
            this.lbl_Version.Location = new System.Drawing.Point(3, 496);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(48, 13);
            this.lbl_Version.TabIndex = 10;
            this.lbl_Version.Text = "[Version]";
            // 
            // btn_PlayerList
            // 
            this.btn_PlayerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlayerList.Location = new System.Drawing.Point(-2, 41);
            this.btn_PlayerList.Name = "btn_PlayerList";
            this.btn_PlayerList.Size = new System.Drawing.Size(204, 60);
            this.btn_PlayerList.TabIndex = 11;
            this.btn_PlayerList.Text = "Player List";
            this.btn_PlayerList.UseVisualStyleBackColor = true;
            this.btn_PlayerList.Click += new System.EventHandler(this.ChangePage);
            // 
            // btn_TeamList
            // 
            this.btn_TeamList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TeamList.Location = new System.Drawing.Point(-2, 100);
            this.btn_TeamList.Name = "btn_TeamList";
            this.btn_TeamList.Size = new System.Drawing.Size(204, 60);
            this.btn_TeamList.TabIndex = 12;
            this.btn_TeamList.Text = "Team List";
            this.btn_TeamList.UseVisualStyleBackColor = true;
            this.btn_TeamList.Click += new System.EventHandler(this.ChangePage);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tools";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_BuildTeam
            // 
            this.btn_BuildTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuildTeam.Location = new System.Drawing.Point(-2, 221);
            this.btn_BuildTeam.Name = "btn_BuildTeam";
            this.btn_BuildTeam.Size = new System.Drawing.Size(204, 60);
            this.btn_BuildTeam.TabIndex = 16;
            this.btn_BuildTeam.Text = "Build Team";
            this.btn_BuildTeam.UseVisualStyleBackColor = true;
            this.btn_BuildTeam.Click += new System.EventHandler(this.ChangePage);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox2.BackgroundImage = global::TeamConfigurator_2.Properties.Resources.btm_team;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 56);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.BackgroundImage = global::TeamConfigurator_2.Properties.Resources.btm_player;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 56);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btn_BuildTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_TeamList);
            this.Controls.Add(this.btn_PlayerList);
            this.Controls.Add(this.lbl_Version);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Navigation";
            this.Size = new System.Drawing.Size(200, 519);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Button btn_PlayerList;
        private System.Windows.Forms.Button btn_TeamList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BuildTeam;
    }
}
