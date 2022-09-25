using Shared.UI.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared.UI.UserControls
{
    /*
     * text color : 247; 127; 0
     * background : 47; 47; 58
     * 
     * text color 1 : 247; 127; 0
     * 
     */

    public partial class NodeTextPagesUC : UserControl
    {
        NodeTextPages nodeTextPages = null;

        public event EventHandler ObjectChanged;
        public event EventHandler AddPageRequired;

        public NodeTextPagesUC()
        {
            InitializeComponent();
        }

        public void SetJsonFromDb(string jsontxt)
        {
            nodeTextPages = new NodeTextPages(jsontxt);
            WorkspaceText.Text = nodeTextPages.Page;
            txtPageText.Text = $"{nodeTextPages.PageNo}/{nodeTextPages.MaxPage}";
            WorkspaceText.TextChanged += WorkspaceText_TextChanged;
        }

        private void WorkspaceText_TextChanged(object sender, EventArgs e)
        {
            OnObjectChanged();
        }

        public string Page => nodeTextPages.Page;
        public string DbText => nodeTextPages.DbText;
        public void AddPage(string txt, string nme)
        {
            dontObserveText = true;
            nodeTextPages.Page = WorkspaceText.Text;
            nodeTextPages.AddPage(txt, nme);
            WorkspaceText.Text = nodeTextPages.Page;
            txtPageText.Text = $"{nodeTextPages.PageNo}/{nodeTextPages.MaxPage}";
            dontObserveText = false;
            OnObjectChanged();
        }
        public string FirstPageText()
        {
            return nodeTextPages.FirstPageText();
        }

        public void CommitCurrentPage()
        {
            nodeTextPages.Page = WorkspaceText.Text;
        }

        private void OnObjectChanged()
        {
            if(dontObserveText == false)
                ObjectChanged?.Invoke(this, EventArgs.Empty);
        }
        private void OnAddPageRequired()
        {
            AddPageRequired?.Invoke(this, EventArgs.Empty);
        }

        bool dontObserveText = false;

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            dontObserveText = true;
            nodeTextPages.Page = WorkspaceText.Text;
            nodeTextPages.prevPage();
            WorkspaceText.Text = nodeTextPages.Page;
            txtPageText.Text = $"{nodeTextPages.PageNo}/{nodeTextPages.MaxPage}";
            dontObserveText = false;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            dontObserveText = true;
            nodeTextPages.Page = WorkspaceText.Text;// забираем текст перед сменой страницы.
            nodeTextPages.nextPage();
            WorkspaceText.Text = nodeTextPages.Page;
            txtPageText.Text = $"{nodeTextPages.PageNo}/{nodeTextPages.MaxPage}";
            dontObserveText = false;
        }

        private void brnAddPage_Click(object sender, EventArgs e)
        {
            OnAddPageRequired();
        }

        private void btnKillPage_Click(object sender, EventArgs e)
        {
            dontObserveText = true;
            nodeTextPages.killPage();
            WorkspaceText.Text = nodeTextPages.Page;
            txtPageText.Text = $"{nodeTextPages.PageNo}/{nodeTextPages.MaxPage}";
            dontObserveText = false;
            OnObjectChanged();
        }
    }
}
