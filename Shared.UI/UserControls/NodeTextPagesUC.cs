using Domain.Entities;
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
        public event EventHandler<NodeTextPage> RemovePageRequired;
        public event EventHandler<string> OpenNodeById;

        public string Page => nodeTextPages.Page;
        //public string DbText => nodeTextPages.DbText;
        public string SelectedText
        {
            get
            {
                return WorkspaceText.SelectedText;
            }
            set
            {
                WorkspaceText.SelectedText = value;
            }
        }
            

        public NodeTextPagesUC()
        {
            InitializeComponent();
        }

        public void SetNode(Node node)
        {
            nodeTextPages = new NodeTextPages(node);
            WorkspaceText.Text = nodeTextPages.Page;
            txtPageText.Text = $"{nodeTextPages.CurrentPageNo}/{nodeTextPages.MaxPage}";
            WorkspaceText.TextChanged += WorkspaceText_TextChanged;
        }

        public void AddPage(string txt, string nme)
        {
            dontObserveText = true;
            nodeTextPages.Page = WorkspaceText.Text;
            nodeTextPages.AddPage(txt, nme);
            WorkspaceText.Text = nodeTextPages.Page;
            txtPageText.Text = $"{nodeTextPages.CurrentPageNo}/{nodeTextPages.MaxPage}";
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
        private void WorkspaceText_TextChanged(object sender, EventArgs e)
        {
            OnObjectChanged();
        }
        private void OnObjectChanged()
        {
            if(dontObserveText == false)
                ObjectChanged?.Invoke(this, EventArgs.Empty);
        }
        private void OnDeleteNodeTextPage()
        {
            RemovePageRequired?.Invoke(this, nodeTextPages.GetPageObject());
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
            txtPageText.Text = $"{nodeTextPages.CurrentPageNo}/{nodeTextPages.MaxPage}";
            dontObserveText = false;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            dontObserveText = true;
            nodeTextPages.Page = WorkspaceText.Text;// забираем текст перед сменой страницы.
            nodeTextPages.nextPage();
            WorkspaceText.Text = nodeTextPages.Page;
            txtPageText.Text = $"{nodeTextPages.CurrentPageNo}/{nodeTextPages.MaxPage}";
            dontObserveText = false;
        }

        private void brnAddPage_Click(object sender, EventArgs e)
        {
            OnAddPageRequired();
        }

        private void btnKillPage_Click(object sender, EventArgs e)
        {
            dontObserveText = true;
            OnDeleteNodeTextPage();// Удаляем объект в бд. СНАЧАЛА УДАЛИМ В БД
            nodeTextPages.killPage();// А ПОТОМ Удаляем элемент в памяти
            WorkspaceText.Text = nodeTextPages.Page;
            txtPageText.Text = $"{nodeTextPages.CurrentPageNo}/{nodeTextPages.MaxPage}";
            dontObserveText = false;
            //OnObjectChanged();// мы ведь убиваем объект, нет смысла помечать несохраненным, так как фактически все сохранено в бд
        }

        private void openNodeByIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenNodeById?.Invoke(sender, WorkspaceText.SelectedText);
        }
    }
}
