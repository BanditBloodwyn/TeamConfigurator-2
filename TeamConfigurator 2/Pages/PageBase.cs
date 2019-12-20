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
        public PageBase()
        {
            InitializeComponent();
        }

        public virtual void Initialize()
        {

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
