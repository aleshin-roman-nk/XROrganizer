using Domain.DBContext;
using Domain.Repos;
using System;
using System.Linq;
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
				.RegisterType<ISessionRepository, SessionRepository>()
				.RegisterType<IAppDataContextFactory, AppDataContextFactory>();


			test3(container);
			Console.ReadLine();
		}

		static void test3(IUnityContainer container)
        {
			INodeRepository repo = container.Resolve<INodeRepository>();

			//var i = repo.Get(894);

			int page = 0;

			var sess = repo.GetTopSessions(DateTime.Now, 894, 3, page);

			while(sess.Count() > 0)
            {
                Console.WriteLine($"page #{page}");
				foreach (var item in sess)
					Console.WriteLine($"#{item.Id} - {item.Start.ToShortDateString()}");
				page++;
				sess = repo.GetTopSessions(DateTime.Now, 894, 3, page);
			}

            Console.WriteLine("the end");
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
			var items = repo.GetAllChildTasksOf(i);
			//var items = repo.GetCompletedSessionOf(i);

			foreach (var item in items)
			{
				Console.WriteLine($"{item.path}#{item.id}");
				//Console.WriteLine($"session:{item.Start} #{item.Id} task:{item.Owner.path}#{item.NodeId}");
			}
		}
	}
}
