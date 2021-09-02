using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace UnityContExmpl
{
	class Program
	{
		static void Main(string[] args)
		{
			IUnityContainer container = new UnityContainer();

			container.RegisterType<IView, View>();

			Presenter p = (Presenter)container.Resolve(typeof(Presenter));

			Console.ReadLine();
		}
	}
}
