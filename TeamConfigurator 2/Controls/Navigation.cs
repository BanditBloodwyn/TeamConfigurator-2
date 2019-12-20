using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamConfigurator_2.Controls
{
    public partial class Navigation : UserControl
    {
        public Navigation()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            lbl_Version.Text = Application.ProductVersion;
        }

        private void ChangePage(object sender, EventArgs e)
        {
            MainPage oParent = this.ParentForm as MainPage;
            Label oLabel = sender as Label;
            string sPageName = "";

            switch (oLabel.Name)
            {
                case "label1":
                    break;

                case "lbl_Players":
                    oParent.ChangePage("Players");
                    break;

                case "lbl_Teams":
                    oParent.ChangePage("Teams");
                    break;

                case "label2":
                    break;

                case "lbl_Version":
                    break;
            }

            oParent.ChangePage(sPageName);
        }
    }
}
