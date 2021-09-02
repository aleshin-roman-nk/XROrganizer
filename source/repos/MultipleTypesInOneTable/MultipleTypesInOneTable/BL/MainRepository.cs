using MultipleTypesInOneTable.BL.Enities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTypesInOneTable.BL
{
	public class MainRepository: IRepo
	{
		AppDb db = new AppDb("Data Source = data.db");

		public MainRepository(Action<string> logger)
		{
			db.Database.Log = logger;
		}

		public IEnumerable<INode> GetAll(/*string type*/)
		{
			var res = db.Nodes.ToList();
			//var res = db.Nodes.OfType<TaskNode>().ToList();

			return res;
		}

		public void Save()
		{

		}

		public void Kill(INode n)
		{
			db.Nodes.Remove((Node)n);
			db.SaveChanges();
		}

		public void Create(INode n)
		{
			db.Nodes.Add(n as Node);
			db.SaveChanges();

			//if(n.type == "task")
			//{
			//	db.TaskNodes.Add((TaskNode)n);
			//	db.SaveChanges();
			//}
			//else if (n.type == "note")
			//{
			//	db.NoteNodes.Add((NoteNode)n);
			//	db.SaveChanges();
			//}
			//else if(n.type == "common")
			//{
			//	db.Nodes.Add((Node)n);
			//	db.SaveChanges();
			//}
			//else if(n.type == "clover")
			//{
			//	db.CatLovers.Add((CatLover)n);
			//	db.SaveChanges();
			//}
		}

		public void Save(INode n)
		{
			db.SaveChanges();

			//if (n.type.Equals("note"))
			//{
			//	NoteNode o = n as NoteNode;
			//	db.NoteNodes.Add
			//}
			//else if (n.type.Equals("task"))
			//{

			//}
		}
	}
}
