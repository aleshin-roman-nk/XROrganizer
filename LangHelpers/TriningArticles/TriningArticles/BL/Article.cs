using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriningArticles.BL
{
	public class Article
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Lang { get; set; }
		public string Content { get; set; } // превратить в путь к файлу
		public string WorkText { get; set; } // превратить в путь к файлу
		public string TxtContent { get; set; }
		public DateTime DateTime { get; set; }
	}
}
