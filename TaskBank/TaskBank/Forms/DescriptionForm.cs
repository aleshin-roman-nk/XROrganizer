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
		public DescriptionForm()
		{
			InitializeComponent();

			descriptionUC1.Save += DescriptionUC1_Save;
		}

		private void DescriptionUC1_Save(object sender, INode e)
		{
			Save?.Invoke(this, e);
		}

		public event EventHandler<INode> Save;

		public void Put(INode n)
		{
			if (n == null) return;
			lblPath.Text = $"{n.path}#{n.id}";
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
	}
}
