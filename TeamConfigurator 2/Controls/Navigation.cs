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
            Control oButton = sender as Control;
            string sPageName = "";

            switch (oButton.Name)
            {
                case "label1":
                    break;

                case "btn_PlayerList":
                    oParent.ChangePage("Players");
                    break;

                case "btn_TeamList":
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
