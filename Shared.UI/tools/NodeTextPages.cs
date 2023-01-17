using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using xorg.Tools;

namespace Shared.UI.tools
{
    internal class NodeTextPages
    {
        Node node;

        //public NodeTextPages(string txt)
        public NodeTextPages(Node node)
        {
            this.node = node;
        }
        //public string DbText => _ser();
        public string Page
        {
            get
            {
                return _currentPage == 0 ? node.text : node.textPages.ElementAt(_currentPage - 1).text;
            }
            set
            {
                if(_currentPage == 0) node.text = value;
                else node.textPages.ElementAt(_currentPage - 1).text = value;
            }
        }

        public NodeTextPage GetPageObject()
        {
            return _currentPage == 0 ? null : node.textPages.ElementAt(_currentPage - 1);
        }

        public void AddPage(string txt, string title)
        {
            node.textPages.Add(new NodeTextPage { title = title, text = txt});
            // now the pointer must be on the last item
            // the last item is on: first item + node.textPages.Count - 1
            _currentPage = 1 + (node.textPages.Count - 1);
        }

        // there is not a zero-page
        public int MaxPage => node.textPages.Count + 1;
        public int CurrentPageNo => _currentPage + 1;// we do not want to see that first page is 0
        private int _currentPage { get; set; }

        public string FirstPageText()
        {
            return node.text;
        }

        public void nextPage()
        {
            if(_currentPage < 1 + node.textPages.Count - 1)
                _currentPage++;
        }

        public void prevPage()
        {
            if (_currentPage > 0)
                _currentPage--;
        }

        public void killPage()
        {
            //if (node.textPages.Count == 0) return;
            if (_currentPage == 0) return;

            node.textPages.Remove(node.textPages.ElementAt(_currentPage - 1));

            if (_currentPage > 1 + node.textPages.Count - 1) _currentPage = 1 + node.textPages.Count - 1;
        }

    }
}
