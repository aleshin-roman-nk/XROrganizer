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

namespace Shared.UI.UserControls
{
	public partial class DescriptionUC : UserControl, IDescriptionView
	{
		SavingObserver savingObserver;

		INode _node = null;

		public event EventHandler<INode> Save;

		public DescriptionUC()
		{
			InitializeComponent();

			savingObserver = new SavingObserver();

			savingObserver.Indicator = lblSaved;
		}

		private class SavingObserver
		{
			bool _savedValue = false;

			public Control Indicator { get; set; }
			public bool Saved
			{
				get
				{
					return _savedValue;
				}
				set
				{
					_savedValue = value;

					if (_savedValue)
					{
						Indicator.BackColor = Color.Green;
						Indicator.Text = "[OK]";
					}
					else
					{
						Indicator.BackColor = Color.Red;
						Indicator.Text = "[X]";
					}
				}
			}
		}

		private void rtxNodeDescription_TextChanged(object sender, EventArgs e)
		{
			if(!_dontObserveSavingState)
				savingObserver.Saved = false;
		}

		private void rtxNodeDescription_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.S)
			{
				_commitAndSave();
				e.Handled = true;
			}
		}

		void _commitAndSave()
		{
			if (_node != null)
			{
				if (string.IsNullOrEmpty(_node.definition)) _node.definition = "";

				// We only need to know if rtxNodeDescription.Text has changed.
				//if (!_node.description.Equals(rtxNodeDescription.Text))
				if (savingObserver.Saved == false)
				{
					_node.definition = rtxNodeDescription.Text;
					Save?.Invoke(this, _node);
				}
			}
			savingObserver.Saved = true;
		}

		bool _dontObserveSavingState = false;

		public void Put(INode n)
		{
			_dontObserveSavingState = true;

			_commitAndSave();

			_node = n;
			rtxNodeDescription.Text = _node.definition;

			_dontObserveSavingState = false;
		}
	}
}
