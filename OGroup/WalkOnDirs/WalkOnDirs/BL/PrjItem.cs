using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkOnDirs.BL
{
	/// <summary>
	/// Item of a project. It might be a task or idea or just note.
	/// </summary>
	public class PrjItem
	{
		public int ProjectId { get; set; }
		public string Tag { get; set; }
		public string Text { get; set; }
	}
}
