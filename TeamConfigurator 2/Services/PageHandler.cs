using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamConfigurator_2.Pages;
using TeamConfigurator_2.Controls;

namespace TeamConfigurator_2.Services
{
    class PageHandler
    {
        /// <summary>
        /// The control used to display the content of the page
        /// </summary>
        private TabControl m_PagePanel;
        
        private CustomTabPage m_CurrentPage;
        private CustomTabPage m_LastPage;
        private CustomTabPage m_StartPage;

        /// <summary>
        /// The list of all pages.
        /// Two different pages never have the same name.
        /// </summary>
        private Dictionary<string, CustomTabPage> m_dictPages;

        internal PageHandler(TabControl pagePanel)
        {
            m_PagePanel = pagePanel;
            m_PagePanel.TabPages.Clear();

            m_dictPages = new Dictionary<string, CustomTabPage>();
        }

        /// <summary>
        /// Return the current visible Page
        /// </summary>
        public CustomTabPage CurrentPage
        {
            get
            {
                return m_CurrentPage;
            }
        }

        public bool CreatePage(string sPageName, PageBase page, bool bIsStartPage = false)
        {
            if(m_dictPages.ContainsKey(sPageName))
            {
                return false;
            }

            CustomTabPage tab = new CustomTabPage(page);

            tab.Text = sPageName;
            m_dictPages.Add(sPageName, tab);

            if (bIsStartPage && m_StartPage == null)
            {
                m_StartPage = tab;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Return the current visible Page
        /// </summary>
        private bool ShowPage(CustomTabPage tab)
        {
            if (tab == null)
            {
                // just view an empty page
                m_PagePanel.SelectedTab = tab;
                m_LastPage = m_CurrentPage;
                m_CurrentPage = tab;
                return true;
            }

            if (tab.Equals(m_CurrentPage))
            {
                return false;
            }

            if (!m_PagePanel.TabPages.Contains(tab))
            {
                m_PagePanel.TabPages.Add(tab);
            }

            if(m_PagePanel.SelectedTab != tab)
                m_PagePanel.SelectedTab = tab;

            m_LastPage = m_CurrentPage;
            m_CurrentPage = tab;
            (m_CurrentPage.Page as IPage).ActivatePage();

            return true;
        }

        public bool ShowPage(string sPageName)
        {
            if(m_dictPages.ContainsKey(sPageName))
            {
                ShowPage(m_dictPages[sPageName]);
                return true;
            }
            return false;
        }

        public bool ShowLastPage(int index)
        {
            bool dShown = false;
            dShown = ShowPage(m_LastPage);

            return dShown;
        }
        
        public bool ShowStartPage(int index)
        {
            bool dShown = false;
            dShown = ShowPage(m_StartPage);

            return dShown;
        }
    }
}
