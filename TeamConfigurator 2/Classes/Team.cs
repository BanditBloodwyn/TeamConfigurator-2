using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConfigurator_2.Classes
{
    class Team
    {
        private List<Player> m_dicRegulars;
        private List<Player> m_dicReserves;
        private League m_oLeague;

        public Team()
        {
            m_dicRegulars = new List<Player>();
            m_dicReserves = new List<Player>();

            m_dicRegulars.Clear();
            m_dicReserves.Clear();
        }

    }
}
