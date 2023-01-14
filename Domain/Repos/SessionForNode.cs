using Domain.DBContext;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repos
{
    public class SessionForNode
    {
        private INode node;
        private readonly IAppDataContextFactory dbFactory;

        //public SessionForNode(INode node, IAppDataContextFactory dbFactory) 
        //{
        //    this.node = node;
        //    this.dbFactory = dbFactory;
        //}

        public SessionForNode(int nodeId, IAppDataContextFactory dbFactory)
        {
            this.dbFactory = dbFactory;

            using (var db = dbFactory.Create())
            {
                node = db.Nodes.FirstOrDefault(x => x.id == nodeId);
            }
        }

        public void Create(OSession s)
        {
            using (var db = dbFactory.Create())
            {
                node = db.Nodes.FirstOrDefault(x => x.id == node.id);
                if (node == null) return;

                s.DNA = node.DNA;
                s.NodeId = node.id;

                db.Entry(s).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
            }
        }

        public bool SessionExists(DateTime dt)
        {
            using (var db = dbFactory.Create())
            {
                DateTime dt1 = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0);
                DateTime dt2 = dt1.AddDays(1);

                return db.Sessions.Any(x => x.NodeId == node.id && x.Start >= dt1 && x.Start < dt2);
            }
        }
    }
}
