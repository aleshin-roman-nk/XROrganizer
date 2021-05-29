using Domain.Entities;
using Domain.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
	public class RmTaskModel
	{
		Note _obj;

		public RmTaskModel(Note t)
		{
			_obj = t;
		}

		public Note Clone()
		{
			return CloneObject.Clone<Note>(_obj);
		}

		public void Accept(Note t)
		{
			if (t.id != _obj.id) throw new ArgumentException("Id does not fit to observable instance.");

			//_obj.Imp = t.Imp;
			_obj.description = t.description;
			_obj.date = t.date;
			_obj.name = t.name;
			_obj.owner_id = t.owner_id;
			_obj.type = t.type;
		}
	}
}
