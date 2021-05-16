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
		OTask _obj;

		public RmTaskModel(OTask t)
		{
			_obj = t;
		}

		public OTask Clone()
		{
			return CloneObject.Clone<OTask>(_obj);
		}

		public void Accept(OTask t)
		{
			if (t.Id != _obj.Id) throw new ArgumentException("Id does not fit to observable instance.");

			_obj.Imp = t.Imp;
			_obj.Text = t.Text;
			_obj.DateTime = t.DateTime;
			_obj.Title = t.Title;
		}
	}
}
