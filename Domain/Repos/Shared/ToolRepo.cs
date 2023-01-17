using Domain.DBContext;
using Domain.dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xorg.Tools;

namespace Domain.Repos.Shared
{
	public class ToolRepo
	{
		public ToolRepo()
		{
		}
		private string GetPathOf(NodeDTO n, AppData db)
		{
			List<string> nodes = new List<string>();

			var n_ownerId = db.Nodes.Where(x => x.id == n.id).Select(x => x.owner_id).FirstOrDefault();

			var __parent = db.Nodes
				.Where(x => x.id == n_ownerId)
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

        public string getFullPathOf(int nodeId, AppData db)
		{

			if (nodeId <= 0) return "";

            string res;

			var node = db.Nodes.FirstOrDefault(x => x.id == nodeId);
			var n = new NodeDTO { id = node.id, name = node.name, type = node.type };

            if (!string.IsNullOrEmpty(n.name))
                res = $"{GetPathOf(n, db)}{n.name}";
            else
                res = $"{GetPathOf(n, db)}#{n.id}";

            return res;
        }

    }
}
