using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTest.DirNavigator
{
	public class IconProvider
	{
		public IconProvider(string fldfile, string tskfile, string upfile)
		{
			Folder = Image.FromFile(fldfile);
			LTask = Image.FromFile(tskfile);
			OutFolder = Image.FromFile(upfile);
		}

		public Image Folder { get; }
		public Image LTask { get; }
		public Image OutFolder { get; }
	}
}
