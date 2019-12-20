using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamConfigurator_2.Pages
{
    public partial class PageBase : UserControl, IPage
    {
        private string m_sPageName;

        public PageBase()
        {
            InitializeComponent();
        }

        public virtual void Initialize(string sPageName)
        {
            m_sPageName = sPageName;
        }

        public virtual void DeactivatePage()
        {

        }

        public virtual void ActivatePage()
        {

        }

        public virtual void InitializePage()
        {

        }

    }
}
