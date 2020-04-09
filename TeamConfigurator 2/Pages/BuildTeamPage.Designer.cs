namespace TeamConfigurator_2.Pages
{
    partial class BuildTeamPage
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
            this.olv_Teams = new BrightIdeasSoftware.ObjectListView();
            this.col_Name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.col_LPZ = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olv_Teams)).BeginInit();
            this.SuspendLayout();
            // 
            // olv_Teams
            // 
            this.olv_Teams.AllColumns.Add(this.col_Name);
            this.olv_Teams.AllColumns.Add(this.col_LPZ);
            this.olv_Teams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olv_Teams.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.olv_Teams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.olv_Teams.CellEditUseWholeCell = false;
            this.olv_Teams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Name,
            this.col_LPZ});
            this.olv_Teams.Cursor = System.Windows.Forms.Cursors.Default;
            this.olv_Teams.HideSelection = false;
            this.olv_Teams.Location = new System.Drawing.Point(3, 56);
            this.olv_Teams.Name = "olv_Teams";
            this.olv_Teams.Size = new System.Drawing.Size(640, 401);
            this.olv_Teams.TabIndex = 5;
            this.olv_Teams.UseCompatibleStateImageBehavior = false;
            this.olv_Teams.View = System.Windows.Forms.View.Details;
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
            // TeamListPage
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.olv_Teams);
            this.Name = "TeamListPage";
            this.Size = new System.Drawing.Size(797, 457);
            ((System.ComponentModel.ISupportInitialize)(this.olv_Teams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olv_Teams;
        private BrightIdeasSoftware.OLVColumn col_Name;
        private BrightIdeasSoftware.OLVColumn col_LPZ;
    }
}
