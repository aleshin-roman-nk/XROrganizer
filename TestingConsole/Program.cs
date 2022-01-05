using Domain.DBContext;
using Domain.Repos;
using System;
using Unity;
using xorg.Tools;

namespace TestingConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			IUnityContainer container = new UnityContainer();

			container
				.RegisterType<IBufferTaskRepository, BufferTaskRepository>()
				.RegisterType<IDbConf, DbConf>()
				.RegisterType<INodeRepository, NodeRepository>()
				.RegisterType<IAppDataContextFactory, AppDataContextFactory>();


			test2(container);
			Console.ReadLine();
		}

		static void test2(IUnityContainer container)
		{
			var _repoBuff = container.Resolve<IBufferTaskRepository>();

			var o = _repoBuff.Create(893);

			Debugger.ShowObjectConsole(o);
		}

		static void test1(IUnityContainer container)
		{
			INodeRepository repo = container.Resolve<INodeRepository>();
			var i = repo.Get(1);//xorg
			var items = repo.GetAllChildrenOf(i);

			foreach (var item in items)
			{
				Console.WriteLine($"{item.path}#{item.id}");
			}
		}
	}
}
