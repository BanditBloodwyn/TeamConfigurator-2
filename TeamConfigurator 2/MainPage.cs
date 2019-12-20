using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamConfigurator_2.Services;

namespace TeamConfigurator_2
{
    public partial class MainPage : Form
    {
        static internal PageHandler ms_PageHandler;

        public MainPage()
        {
            InitializeComponent();

            ms_PageHandler = new PageHandler(panel_PagePanel);
        }

        public bool ChangePage(string sPageName)
        {
            return true;
        }
    }
}
