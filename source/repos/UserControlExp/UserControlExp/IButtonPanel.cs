using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlExp
{
	public interface IButtonPanel
	{
		Button SaveButton { get; set; }
		Button DeleteButton { get; set; }
	}
}
