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
            var fname = args[0];

            if (File.Exists(fname))
            {
                Console.WriteLine($"File `{fname}` is ready to work");

                var cs = $"Data Source={fname}";

                NodeRepository repo = new NodeRepository(new AppFactoryConsole(cs));

                repo.UpdateDNA();
            }
            else
                Console.WriteLine($"File `{fname}` is not found");

            //foreach (var item in args)
            //{
            //    Console.WriteLine($"[{item}]");
            //}
        }
    }
}
