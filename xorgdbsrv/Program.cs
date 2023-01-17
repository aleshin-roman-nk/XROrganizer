using Domain.dto;
using Domain.Repos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xorgdbsrv
{

	//@"Data Source=..\db\xorgData.db"

	internal class Program
	{
		static void Main(string[] args)
		{
            //var fname = args[0];

            var fname = "xorgdata.db";

            if (File.Exists(fname))
            {
                Console.WriteLine($"File `{fname}` is ready to work");
                var cs = $"Data Source={fname}";

                //NodeRepository repo = new NodeRepository(new AppFactoryConsole(cs));
                //repo.UpdateDNA();

                PushUpdateRepoTool repo = new PushUpdateRepoTool(new AppFactoryConsole(cs));
                
                repo.TransformNodesTextPages();
            }
            else
                Console.WriteLine($"File `{fname}` is not found");

            Console.WriteLine("DONE!!!");
            Console.ReadLine();
		}
	}
}
