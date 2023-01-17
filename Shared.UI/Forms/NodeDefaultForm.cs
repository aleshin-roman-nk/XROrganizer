using Domain.Entities;
using Shared.UI.Interfaces;
using Shared.UI.Interfaces.EventArgsDefinition;
using Shared.UI.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared.UI.Forms
{
    public partial class NodeDefaultForm : Form, INodeDefaultView
    {
        SavingObserver savingObserver;

        INode _ent;
        private readonly IInputBox _dlg;

        public event EventHandler<SaveNodeEventArgs> Save;
        public event EventHandler Completed;
        public event EventHandler<NodeTextPage> DeleteNodeTextPage;
        public event EventHandler<int> OpenNodeById;

        public int ObjId => _ent.id;

        public NodeDefaultForm(IInputBox dlg)
        {
            InitializeComponent();

            savingObserver = new SavingObserver();
            savingObserver.Indicator = lblSaved;
            savingObserver.Saved = true;
            this._dlg = dlg;
        }

        private void OnNodeSave()
        {
            SaveNodeEventArgs ev = new SaveNodeEventArgs(_get());
            Save?.Invoke(this, ev);
            savingObserver.Saved = ev.IsNodeSaved;
        }

        private INode _get()
        {
            // todo: collect all properties
            _ent.pinned = checkBoxPinned.Checked;
            _ent.name = textBoxName.Text;
            nodeTextPagesUC1.CommitCurrentPage();
            //_ent.text = nodeTextPagesUC1.DbText;

            updateName(_ent);

            return _ent;
        }

        private void updateName(INode ent)
        {
            if (!string.IsNullOrEmpty(_ent.name)) return;

            string str = nodeTextPagesUC1.FirstPageText();

            // c# 8.0 or higher
            //using var reader = new StringReader(str);
            //string first = reader.ReadLine();

            using (var reader = new StringReader(str))
            {
                ent.name = reader.ReadLine();
            }
        }

        private void _set(INode o)
        {
            _ent = o;

            textBoxDate.Text = _ent.date.Value.ToShortDateString();
            textBoxPath.Text = $"{_ent.path}";
            textBoxID.Text = _ent.id.ToString();
            textBoxType.Text = _ent.NTypeString;
            textBoxName.Text = _ent.name;
            checkBoxPinned.Checked = _ent.pinned;

            nodeTextPagesUC1.SetNode(_ent as Node);
        }

        private void NodeDefaultForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.S && e.Control)
            {
                OnNodeSave();
                e.Handled = true;
            }
        }

        private void nodeTextPagesUC1_AddPageRequired(object sender, EventArgs e)
        {
            nodeTextPagesUC1.AddPage("", "");
        }

        private void nodeTextPagesUC1_ObjectChanged(object sender, EventArgs e)
        {
            savingObserver.Saved = false;
        }

        public void Restore()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Focus();
        }

        public void Go(INode o)
        {
            _set(o);
            Show();
        }

        private void NodeDefaultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Completed?.Invoke(this, EventArgs.Empty);
        }

        private void btnCloseAndSave_Click(object sender, EventArgs e)
        {
            OnNodeSave();
            Close();
        }

        private void nodeTextPagesUC1_RemovePageRequired(object sender, NodeTextPage e)
        {
            DeleteNodeTextPage?.Invoke(sender, e);
        }

        private void NodeDefaultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!savingObserver.Saved)
            {
                var resp = _dlg.AskUser("There are something unsaved. Do you want to save?");
                if (resp == DlgAnswerCode.yes)
                {
                    OnNodeSave();
                }
                else if (resp == DlgAnswerCode.cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void nodeTextPagesUC1_OpenNodeById(object sender, string e)
        {
            if (!string.IsNullOrEmpty(e))
            {
                int i = 0;
                if (int.TryParse(e, out i))
                    OpenNodeById?.Invoke(this, i);
            }
        }
    }
}
