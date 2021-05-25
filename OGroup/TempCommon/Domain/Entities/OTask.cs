using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	/*
	 * Directory item. Actually this is not only a task. It might be type of a task, a note and etc.
	 * 
	 */
	public class OTask
	{
		public int Id { get; set; }
		public ImportanceLevel Imp { get; set; }// модет просто Level, TaskLevel, 
		public string Title { get; set; }
		public string Text { get; set; }
		public DateTime? DateTime { get; set; }
		public int ItemType { get; set; }
		public int DirectoryId { get; set; }

		public string MiniText
		{
			get
			{
				int lenght = Text.Length > 100 ? 100 : Text.Length;
				return Text.Substring(0, lenght) + "...";
			}
		}
	}

	public enum ImportanceLevel { Total, Middle, Low, Small};
}
