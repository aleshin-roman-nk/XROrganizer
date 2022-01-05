using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBank.Views
{
	public interface IStickable
	{
		Point LocationPoint { get; }
		int width { get; }
		int height { get; }
	}
}
