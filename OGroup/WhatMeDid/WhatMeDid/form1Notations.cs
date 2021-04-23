using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatMeDid.BL;
using WhatMeDid.Presenters;

namespace WhatMeDid
{
	public class form1Notations
	{
		Label _savedStatus;
		RichTextBox _noteField;
		NotationLevel _currentLevel;

		public NotationLevel CurrentLevel => _currentLevel;

		public form1Notations(RichTextBox richText, Label savedstatusfield)
		{
			_savedStatus = savedstatusfield;
			_noteField = richText;
		}

		bool _saved;
		public bool saved
		{
			get
			{
				return _saved;
			}
			set
			{
				_saved = value;
				if (_saved)
					_savedStatus.BackColor = Color.Green;
				else
					_savedStatus.BackColor = Color.Red;
			}
		}

		public void setNotationLevel(NotationLevel level)
		{
			if (level == NotationLevel.Report)
			{
				_noteField.BackColor = Color.SeaGreen;
			}
			else if (level == NotationLevel.Task)
			{
				_noteField.BackColor = Color.LightSeaGreen;
			}

			_currentLevel = level;
		}
	}
}
