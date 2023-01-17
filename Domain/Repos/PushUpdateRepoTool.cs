using Domain.DBContext;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repos
{
	public class PushUpdateRepoTool
	{
		private readonly IAppDataContextFactory factory;

		public PushUpdateRepoTool(IAppDataContextFactory factory)
		{
			this.factory = factory;
		}

		public void TransformNodesTextPages()
		{
			using (var db = factory.Create())
			{
				var nodes = db.Nodes.ToList();

				foreach (var node in nodes)
				{
					var pages = Transform(node.text, node.id);

					if(pages != null)
					{
						node.text = pages[0].text;
						Console.WriteLine($">>> main text: {node.text}");
						for(int i = 1; i < pages.Count(); i++)
						{
							db.Entry(pages[i]).State = EntityState.Added;
							Console.WriteLine($"> page: {pages[i].text}");
						}

						db.Entry(node).State = EntityState.Modified;
					}
				}

				db.SaveChanges();
			}
		}

		NodeTextPage[] Transform(string jsontexppages, int pnodeid)
		{
			var definition = new[] { new { name = "", text = "" } };
			var res = definition;
			try
			{
                res = Newtonsoft.Json.JsonConvert.DeserializeAnonymousType(
					jsontexppages, 
					new[] { new { name = "", text = "" } });

                var output = res.Select(x =>
                {
                    return new NodeTextPage { text = x.text, title = x.name, nodeid = pnodeid };
                }).ToArray();

                return output;

            }
			catch (Exception)
			{
				Console.WriteLine("Bad json");
				return null;
			}
        }
	}
}
