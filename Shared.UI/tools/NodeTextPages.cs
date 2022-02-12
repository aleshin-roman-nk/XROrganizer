using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xorg.Tools;

namespace Shared.UI.tools
{
    internal class NodeTextPages
    {
        List<NodeTextPage> nodeTextPages;

        public NodeTextPages(string txt)
        {
            nodeTextPages = _deser(txt);
        }
        public string DbText => _ser();
        public string Page
        {
            get
            {
                return nodeTextPages[nodePageNumber].text;
            }
            set
            {
                nodeTextPages[nodePageNumber].text = value;
            }
        }
        public void AddPage(string txt, string nme)
        {
            nodeTextPages.Add(new NodeTextPage { name = nme, text = txt});
            nodePageNumber = nodeTextPages.Count - 1;
        }

        // there is not a zero-page
        public int MaxPage => nodeTextPages.Count;
        public int PageNo => nodePageNumber + 1;
        private int nodePageNumber { get; set; }

        public string FirstPageText()
        {
            return nodeTextPages[0].text;
        }

        public void nextPage()
        {
            if(nodePageNumber < nodeTextPages.Count - 1)
                nodePageNumber++;
        }

        public void prevPage()
        {
            if (nodePageNumber > 0)
                nodePageNumber--;
        }

        public void killPage()
        {
            if (nodeTextPages.Count == 1) return;
            nodeTextPages.RemoveAt(nodePageNumber);
            if (nodePageNumber > nodeTextPages.Count - 1) nodePageNumber = nodeTextPages.Count - 1;
        }

        private string _ser()
        {
            return JsonTool.Serialize(nodeTextPages);
        }

        private List<NodeTextPage> _deser(string txt)
        {
            // here strange thing happends.
            // sometimes txt comes as "null", sometimes as not null but empty string.
            if (string.IsNullOrEmpty(txt))
            {
                return new List<NodeTextPage> { new NodeTextPage {name = "", text = "" } };
            }

            List<NodeTextPage> res = null;

            try
            {
                res = JsonTool.Deserialize<List<NodeTextPage>>(txt);
            }
            catch (Exception)
            {
                res = new List<NodeTextPage>();
                res.Add(new NodeTextPage { text = txt });
            }

            return res;
        }

        private class NodeTextPage
        {
            public string name { get; set; }
            public string text { get; set; }
        }
    }
}
