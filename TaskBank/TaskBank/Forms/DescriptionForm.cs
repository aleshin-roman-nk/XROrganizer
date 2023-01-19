using Domain.dto;
using Domain.Entities;
using Shared.UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBank.Views;

namespace TaskBank.Forms
{
	public partial class DescriptionForm : Form, IDescriptionWindow
	{
		NodeDTO node;

		public DescriptionForm()
		{
			InitializeComponent();

			//descriptionUC1.Save += DescriptionUC1_Save;
		}

		private void DescriptionUC1_Save(object sender, INode e)
		{
			Save?.Invoke(this, e);
		}

		public event EventHandler<INode> Save;
        public event EventHandler<NodeDTO> OpenNode;

        public void Put(NodeDTO n)
		{
			node = n;

            if (n == null) return;

            lblPath.Text = string.IsNullOrEmpty(n.name) ? $"#{n.id}" : $"#{n.id} | {n.name}";
			descriptionUC1.Put(n);
		}

		public void StickTo(IStickable to)
		{
			Location = new Point(to.LocationPoint.X + to.width, to.LocationPoint.Y);
		}

		public void Display()
		{
			Show();
		}

		private void DescriptionForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			Hide();
		}

        private void lblPath_Click(object sender, EventArgs e)
        {
			OpenNode?.Invoke(this, node);
        }

		Color color;

        private void lblPath_MouseEnter(object sender, EventArgs e)
        {
			Label l = sender as Label;

			color = l.ForeColor;

			l.ForeColor = Color.Thistle;
        }

        private void lblPath_MouseLeave(object sender, EventArgs e)
        {
            Label l = sender as Label;
            l.ForeColor = color;
        }
    }
}
