using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBank.BL.Entities;
using TaskBank.BL.Tools;

namespace TaskBank.BL.Services
{
	public class RmTaskModel
	{
		RmTask _obj;

		public RmTaskModel(RmTask t)
		{
			_obj = t;
		}

		public RmTask Clone()
		{
			return CloneObject.Clone<RmTask>(_obj);
		}

		public void Accept(RmTask t)
		{
			if (t.Id != _obj.Id) throw new ArgumentException("Id does not fit to observable instance.");

			_obj.Imp = t.Imp;
			_obj.Text = t.Text;
			_obj.DateTime = t.DateTime;
			_obj.Title = t.Title;
		}
	}
}
