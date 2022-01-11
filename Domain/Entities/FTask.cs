using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using xorg.Tools;

namespace Domain.Entities
{
	[Table("Tasks")]
	public class FTask : Node
	{
		public FTask()
		{
			_type = NType.Task;
		}

		public int GivenSeconds { get; set; }
		public bool IsCompleted { get; set; }
		//public string tags { get; set; }
		//public bool IsInCurrentBuffer { get; set; }

		public DateTime completed_date { get; set; }

		private string _name = null;

		private string findNameTag(string input)
		{
			if (string.IsNullOrEmpty(input)) return "";
			if (input == null) return "";

			string firstline;
			if (input.Contains('\n'))
				firstline = input.Substring(0, input.IndexOf('\n'));
			else
				firstline = input.Substring(0, input.Length);

			Regex r = new Regex(@"^###(.*?)$");
			var res = r.Match(firstline);

			if (res.Groups.Count == 2)
				return res.Groups[1].Value.TrimStart(' ');
			else
			{
				return null;
			} 
		}

		// This method most likely will be used in Task edit window.
		// Or add a button in 
		public void updateNameFromDescription()
		{
			_name = findNameTag(definition);
		}

		public override string name
		{
			get
			{
				if(string.IsNullOrEmpty(_name))
				{
					var str = findNameTag(definition);
					if (!string.IsNullOrEmpty(str)) _name = str;
				}

				return _name;
			}
			set
			{
				_name = value;
			}
		}
	}
}
