using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConfigurator_2
{
    public interface IPage
    {
        void InitializePage();
        void ActivatePage();
        void DeactivatePage();
    }
}
