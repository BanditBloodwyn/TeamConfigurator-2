﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamConfigurator_2.Classes;


namespace TeamConfigurator_2.Services
{
    static class DataService
    {
        private static string m_sExportKey = "";
        private static string m_sLoadDate = "";
        private static string m_sLoadTime = "";
        private static Dictionary<string, Player> m_dictPlayers = null;
        private static Dictionary<string, Team> m_dictTeams = null;

        private static XDocument m_oXDoc = null;

        public static string ExportKey
        {
            get { return m_sExportKey; }
            set { m_sExportKey = value; }
        }
        public static string LoadDate
        {
            get { return m_sLoadDate; }
            set { m_sLoadDate = value; }
        }
        public static string LoadTime
        {
            get { return m_sLoadTime; }
            set { m_sLoadTime = value; }
        }

        public static Dictionary<string, Player> Players
        {
            get 
            {
                if (m_dictPlayers == null)
                    m_dictPlayers = new Dictionary<string, Player>();
                return m_dictPlayers; 
            }
        }
        public static Dictionary<string, Team> Teams
        {
            get
            {
                if (m_dictTeams == null)
                    m_dictTeams = new Dictionary<string, Team>();
                return m_dictTeams;
            }
        }

        public static bool LoadPlayersFromURL()
        {
            return LoadPlayersFromURL(m_sExportKey);
        }

        public static bool LoadPlayersFromURL(string sExportKey)
        {
            m_sExportKey = sExportKey;
            Players.Clear();

            try
            {
                m_oXDoc = XDocument.Load("https://dresden-stadt.tischtennislive.de/Export/default.aspx?SpartenID=1782&Format=XML&SportArt=96&Area=VereinLivePZ&ExportKey=" + sExportKey);

                if (m_oXDoc == null)
                    return false;

                m_sLoadDate = (string)m_oXDoc.Root.Element("Datum");
                m_sLoadTime = (string)m_oXDoc.Root.Element("Zeit");

                foreach (XElement element in m_oXDoc.Root
                                .Element("Content")
                                .Elements("Spieler"))
                {
                    Player oPlayer = new Player();
                    oPlayer.Name = (string)element.Element("Spielername");
                    oPlayer.BirthYear = (int)element.Element("Gebdatum");
                    oPlayer.Sex = (string)element.Element("Geschlecht");

                    string sLPZTemp = (string)element.Element("LivePZ");
                    char[] cTemp = { '[', ']', '*', ' ' };
                    sLPZTemp = sLPZTemp.Trim(cTemp);

                    if(sLPZTemp == "k.A.")
                    {
                        oPlayer.LPZ = 0;
                    }
                    else
                    {
                        oPlayer.LPZ = Convert.ToInt32(sLPZTemp);
                    }

                    m_dictPlayers.Add(oPlayer.Name, oPlayer);
                }

                return true;
            }
            catch(System.Net.WebException)
            {
                Console.WriteLine("Website not reachable!");
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception! \n Source: {0} \n Message: {1} \n Type: \n {2} \n StackTrace:{3}", e.Source, e.Message, e.GetType(), e.StackTrace);
                return false;
            }

        }
    }
}
