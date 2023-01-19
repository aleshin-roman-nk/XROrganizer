using Domain.dto;
using Domain.Entities;
using Shared.UI.Interfaces;
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
using xorg.Tools;

namespace Shared.UI.UserControls
{

	/*
	 * Black theme:
	 * backgroung = 37; 37; 38
	 * text = 219; 164; 14
	 * 
	 * orange theme:
	 * backgroung = #4B5A20
	 * text = #DBA40E
	 * 
	 */

	public partial class DescriptionUC : UserControl, IDescriptionView
	{
		//SavingObserver savingObserver;

		//NodeDTO _node = null;

		//public event EventHandler<INode> Save;

		public DescriptionUC()
		{
			InitializeComponent();

			//savingObserver = new SavingObserver();

			//savingObserver.Indicator = lblSaved;
		}

		private void rtxNodeDescription_TextChanged(object sender, EventArgs e)
		{
			//if(!_dontObserveSavingState)
			//	savingObserver.Saved = false;
		}

		private void rtxNodeDescription_KeyDown(object sender, KeyEventArgs e)
		{
			//if (e.Control && e.KeyCode == Keys.S)
			//{
			//	_commitAndSave();
			//	e.Handled = true;
			//}
		}

		//void _commitAndSave()
		//{
		//	if (_node != null)
		//	{
		//		if (string.IsNullOrEmpty(_node.text)) _node.text = "";

		//		// We only need to know if rtxNodeDescription.Text has changed.
		//		//if (!_node.description.Equals(rtxNodeDescription.Text))
		//		if (savingObserver.Saved == false)
		//		{
		//			_node.text = rtxNodeDescription.Text;
					
		//			Save?.Invoke(this, _node);
		//		}
		//	}
		//	savingObserver.Saved = true;
		//}

		bool _dontObserveSavingState = false;

		public void Put(NodeDTO n)
		{
			//_dontObserveSavingState = true;

			//_commitAndSave();

			//_node = n;
			rtxNodeDescription.Text = n.text;

			//_dontObserveSavingState = false;
		}
	}
}
