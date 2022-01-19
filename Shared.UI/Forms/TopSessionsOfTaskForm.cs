using Domain.Entities;
using Shared.UI.Interfaces;
using Shared.UI.Interfaces.EventArgsDefinition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared.UI.Forms
{
    public partial class TopSessionsOfTaskForm : Form, ITopSessionsOfTaskView
    {
        int _page = 0;
        int _items_perPage = 3;

        DateTime _date;
        int _taskId = -1;

        public TopSessionsOfTaskForm()
        {
            InitializeComponent();
        }

        public event EventHandler Completed;
        public event EventHandler<SessionsPageRequiredEventArgs> PageChanged;

        private void TopSessionsOfTaskForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Completed?.Invoke(this, EventArgs.Empty);
        }

        private void OnPageChanged()
        {
            var arg = new SessionsPageRequiredEventArgs(
                _page, _items_perPage, _date, _taskId);

            PageChanged?.Invoke(this, arg);
        }

        string generateView(IEnumerable<OSession> sessions)
        {
            var res = new StringBuilder();

            foreach (var item in sessions)
            {
                res.AppendLine($">>> {item.Start}");
                if (string.IsNullOrEmpty(item.Description))
                    res.AppendLine("******************************************");
                else
                {
                    res.AppendLine(item.Description);
                    res.AppendLine("******************************************");
                }
            }

            return res.ToString();
        }

        private void btnPageDown_Click(object sender, EventArgs e)
        {
            _page--;
            if (_page < 0) _page = 0;
            lblPageNumber.Text = _page.ToString();
            OnPageChanged();
        }

        private void btnPageUp_Click(object sender, EventArgs e)
        {
            _page++;
            lblPageNumber.Text = _page.ToString();
            OnPageChanged();
        }

        public void Go(string path, DateTime d, int taskId)
        {
            bool wnd_was_alive = taskId >= 0;

            _page = 0;
            _date = d;
            _taskId = taskId;

            label1.Text = path;
            this.Show();

            if (wnd_was_alive)
            {
                lblPageNumber.Text = _page.ToString();
                OnPageChanged();
            }
        }

        public void Display(IEnumerable<OSession> sessions)
        {
            var str = generateView(sessions);
            if(string.IsNullOrEmpty(str) && _page != 0)
            {
                _page--;
                lblPageNumber.Text = _page.ToString();
                OnPageChanged();
                return;
            }
            else if (string.IsNullOrEmpty(str) && _page == 0)
            {
                richTextBox1.Text = "[no session]";
                return;
            }

            richTextBox1.Text = str;
        }

        private void TopSessionsOfTaskForm_Load(object sender, EventArgs e)
        {
            OnPageChanged();
        }
    }
}
