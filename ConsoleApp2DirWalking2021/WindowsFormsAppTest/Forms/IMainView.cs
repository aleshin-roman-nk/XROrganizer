using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppTest.DirNavigator;

namespace WindowsFormsAppTest.FormComponent
{
	public interface IMainView
	{
		IDirNavigatorView DirNavigatorView { get; }
	}
}
