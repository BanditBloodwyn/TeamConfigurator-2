using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamConfigurator_2.Pages;

namespace TeamConfigurator_2.Services
{
    class PageHandler
    {
        /// <summary>
        /// The control used to display the content of the page
        /// </summary>
        private TabControl m_PagePanel;
        
        private PageBase m_CurrentPage;
        private PageBase m_LastPage;
        private PageBase m_StartPage;

        /// <summary>
        /// The list of all pages.
        /// Two different pages never have the same name.
        /// </summary>
        private Dictionary<string, PageBase> m_dictPages;

        internal PageHandler(TabControl pagePanel)
        {
            m_PagePanel = pagePanel;
            m_PagePanel.TabPages.Clear();

            m_dictPages = new Dictionary<string, PageBase>();
        }

        /// <summary>
        /// Return the current visible Page
        /// </summary>
        public TabPage CurrentPage
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

            page.Text = sPageName;
            m_dictPages.Add(sPageName, page);

            if (bIsStartPage && m_StartPage == null)
            {
                m_StartPage = page;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Return the current visible Page
        /// </summary>
        private bool ShowPage(PageBase page)
        {
            if (page == null)
            {
                // just view an empty page
                page = new PageBase();
                m_PagePanel.SelectedTab = page;
                m_LastPage = m_CurrentPage;
                m_CurrentPage = page;
                return true;
            }

            if (page.Equals(m_CurrentPage))
            {
                return false;
            }

            if (m_CurrentPage != null)
            {
                (m_CurrentPage as IPage).DeactivatePage();
                if(m_dictPages.ContainsValue(m_CurrentPage))
                {
                    // TODO: set button pressed 
                }
            }

            page.Dock = DockStyle.Fill;

            if (!m_PagePanel.Controls.Contains(page))
            {
                m_PagePanel.TabPages.Add(page);
                m_PagePanel.SelectedTab = page;
            }

            m_LastPage = m_CurrentPage;
            m_CurrentPage = page;
            (m_CurrentPage as IPage).ActivatePage();

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
