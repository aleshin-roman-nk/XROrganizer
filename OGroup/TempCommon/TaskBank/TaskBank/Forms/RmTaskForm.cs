using Domain.Entities;
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
using UIComponents;

namespace TaskBank.Dlg.forms
{
	public partial class RmTaskForm : Form, ISingleEntityView<INode>
	{
		INode _node;

		public RmTaskForm()
		{
			InitializeComponent();
		}

		private void placeObject(INode n)
		{
			textBox1.Text = n.description;
			textBox1.SelectionStart = textBox1.Text.Length;
		}

		private void acceptObject()
		{
			_node.description = textBox1.Text;
		}

		ViewResult<INode> ISingleEntityView<INode>.Go(INode tsk)
		{
			_node = tsk;
			placeObject(_node);

			bool ok = this.ShowDialog() == DialogResult.OK;

			if (ok)
			{
				acceptObject();
				var res = new ViewResult<INode>(_node, true);
				return res;
			}
			else
			{
				return new ViewResult<INode>(null, false);
			}
		}

		private void RmTaskForm_Load(object sender, EventArgs e)
		{
			textBox1.Select();
		}
	}
}
