using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamConfigurator_2.Controls.Popups
{
    public partial class URLPopup : Form
    {
        public URLPopup()
        {
            InitializeComponent();
        }

        public string StartDialog()
        {
            DialogResult oPopupResult = base.ShowDialog();

            if (oPopupResult == DialogResult.OK)
            {
                if(textBox1.Text != "")
                    return textBox1.Text;
            }

            return "";
        }
    }
}
