using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamConfigurator_2.Pages;

namespace TeamConfigurator_2.Controls
{
    public partial class CustomTabPage : TabPage
    {
        private PageBase page;

        public PageBase Page
        {
            get { return page; }
            set { page = value; }
        }

        public CustomTabPage(PageBase page)
        {
            InitializeComponent();

            if (page != null)
            {
                this.page = page;
                this.page.Dock = DockStyle.Fill;
                this.Controls.Add(this.page);
            }
        }
    }
}
