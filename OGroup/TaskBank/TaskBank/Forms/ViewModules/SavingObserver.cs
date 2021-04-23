using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskBank.ViewModules
{
	public class SavingObserver
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
}
