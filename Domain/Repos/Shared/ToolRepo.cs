using Domain.DBContext;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repos.Shared
{
	public class ToolRepo
	{
		IAppDataContextFactory _factory;

		public ToolRepo(IAppDataContextFactory f)
		{
			_factory = f;
		}

		public string GetPathOf(INode n, AppData db)
		{
			List<string> nodes = new List<string>();

			var __parent = db.Nodes
				.Where(x => x.id == n.owner_id)
				.Select(x => new { _id = x.id, _owner_id = x.owner_id, _name = x.name })
				.SingleOrDefault();

			if (__parent != null) nodes.Add(__parent._name);
			while (__parent != null)
			{
				__parent = db.Nodes
					.Where(x => x.id == __parent._owner_id)
					.Select(x => new { _id = x.id, _owner_id = x.owner_id, _name = x.name })
					.SingleOrDefault();

				if (__parent != null)
					nodes.Add(__parent._name);
			}

			nodes.Reverse();

			StringBuilder sb = new StringBuilder();
			foreach (var item in nodes)
			{
				sb.Append($"{item} \\ ");
			}

			return sb.ToString();
		}

		public string getFullPathOf(INode n, AppData db)
		{
			var res = GetPathOf(n, db);
			return $"{res}{n.name} \\ ";
		}

		public IEnumerable<INode> FetchPathsAndSave(IEnumerable<INode> nodes)
		{
			using (var db = _factory.Create())
			{
				foreach (var item in nodes)
				{
					item.path = GetPathOf(item, db);
					//db.Entry(item).State = EntityState.Modified;
				}

				//db.SaveChanges();
				return nodes;
			}
		}

		public string GetPathOf(INode n)
		{
			using (var db = _factory.Create())
			{
				return GetPathOf(n, db);
			}
		}
	}
}
