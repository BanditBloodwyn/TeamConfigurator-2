using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamConfigurator_2.Classes
{
    class Player
    {
        private string m_sName;
        private int m_unBirthYear;
        private string m_cSex;
        private int m_nLPZ;
        private bool m_bBlocked;
        private int m_nAvailability = 100;
        private int m_unPlayedMatches;
        public List<Player> m_listBlackList;
        public List<Player> m_listWhiteList;


        public string Name
        {
            get { return m_sName; }
            set { m_sName = value; }
        }
        public int BirthYear
        {
            get { return m_unBirthYear; }
            set { m_unBirthYear = value; }
        }
        public string Sex
        {
            get { return m_cSex; }
            set { m_cSex = value; }
        }
        public int LPZ
        {
            get { return m_nLPZ; }
            set { m_nLPZ = value; }
        }
        public bool Blocked
        {
            get { return m_bBlocked; }
            set { m_bBlocked = value; }
        }
        public int Availability
        {
            get { return m_nAvailability; }
            set { m_nAvailability = value; }
        }
        public int PlayedMatches
        {
            get { return m_unPlayedMatches; }
            set { m_unPlayedMatches = value; }
        }

        public Player()
        {
            m_listBlackList = new List<Player>();
            m_listWhiteList = new List<Player>();

            m_listBlackList.Clear();
            m_listWhiteList.Clear();
        }

        public void AddPlayerToBlackList(Player oPlayer)
        {
            if (!m_listBlackList.Contains(oPlayer))
            {
                m_listBlackList.Add(oPlayer);
            }
            
        }

        public void AddPlayerToWhiteList(Player oPlayer)
        {
            if (!m_listWhiteList.Contains(oPlayer))
            {
                m_listWhiteList.Add(oPlayer);
            }
        }

        public void RemovePlayerFromBlackList(Player oPlayer)
        {
            m_listBlackList.Remove(oPlayer);
        }

        public void RemovePlayerFromWhiteList(Player oPlayer)
        {
            m_listWhiteList.Remove(oPlayer);
        }

        public bool IsOnBlackList(Player oPlayer)
        {
            if (oPlayer != this)
                return m_listBlackList.Contains(oPlayer);
            else
                return false;
        }

    }
}
