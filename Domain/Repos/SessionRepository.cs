using Domain.DBContext;
using Domain.dto;
using Domain.Entities;
using Domain.Repos.Shared;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace Domain.Repos
{
    public class SessionRepository : ISessionRepository
    {
        IAppDataContextFactory _contextFactory;
        ToolRepo _toolRepo;

        public SessionRepository(IAppDataContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
            _toolRepo = new ToolRepo();
        }

        public void Delete(OSession e)
        {
            using (var db = _contextFactory.Create())
            {
                db.Entry(e).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public IEnumerable<OSession> GetOfDay(DateTime date)
        {
            DateTime dt1 = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
            DateTime dt2 = dt1.AddDays(1);

            using (var db = _contextFactory.Create())
            {
                var res = db.Sessions.Include(x => x.Owner).Where(x => x.Start >= dt1 && x.Start < dt2)
                    .OrderBy(x => x.Start).ToList();

                foreach (var item in res)
                {
                    item.Owner.path = _toolRepo.getFullPathOf(item.Owner.id, db);
                }

                return res;
            }
        }

        //16-01-2023
        // Самое время начать искать по днк

        public IEnumerable<int> GetAllChildIdOf(NodeDTO n)// дать коллекцию
        {
            /*
			 * Возможна оптимизация: не загружать задачи, дата закрытия которых
			 * в предидущем и более ранних месяцах.
			 * Сессии этих задач гарантированно немогут быть в текущем месяце.
			 * 
			 */

            var stack = new Stack<Node>();

            var res = new List<int>();

            using (var db = _contextFactory.Create())
            {
                Func<Node, IEnumerable<Node>> getChildren = (owner) =>
                {
                    return db.Nodes.Where(x => x.owner_id == owner.id).ToList();
                };

                stack.Push(new Node { id = n.id });
                while (stack.Any())
                {
                    var next = stack.Pop();
                    //if (next.type == Enums.NType.Task) res.Add(next.id);
                    if (next.type >= Enums.NType.Dir) res.Add(next.id);
                    foreach (var child in getChildren(next))
                        stack.Push(child);
                }

                return res;
            }
        }

        public IEnumerable<OSession> GetSessionOf(int year, int month, NodeDTO n)
        {
            DateTime dt1 = new DateTime(year, month, 1, 0, 0, 0);
            DateTime dt2 = dt1.AddMonths(1);

            List<OSession> res = new List<OSession>();

            var task_id_collection = GetAllChildIdOf(n);

            using (var db = _contextFactory.Create())
            {
                res = db.Sessions/*.Include(x => x.Owner)*/.Where(sess =>
                      task_id_collection.Contains(sess.NodeId) &&
                      (sess.Start >= dt1 && sess.Start < dt2)
                ).ToList();

                //foreach (var item in res)
                //	item.Owner.path = _toolRepo.GetPathOf(item.Owner, db);
            }

            return res;
        }

        public void Update(OSession e)
        {
            if (e.Id == 0) throw new InvalidOperationException("This is a new object, its id is 0. For update you have to use existing one");

            using (var db = _contextFactory.Create())
            {
                var owner = db.Nodes.FirstOrDefault(x => x.id == e.NodeId);
                if (owner != null)
                {
                    e.Owner = owner;
                    //e.NodeId = dir.Id;
                }

                //db.Entry(e).State = e.Id == 0 ? EntityState.Added : EntityState.Modified;
                db.Entry(e).State = EntityState.Modified;

                db.SaveChanges();
            }
        }
        public int GetSecondsOfDay(DateTime dt, INode own)
        {
            DateTime dt1 = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
            DateTime dt2 = dt1.AddDays(1);

            using (var db = _contextFactory.Create())
            {
                return db.Sessions.Where(x => x.NodeId == own.id && x.Start >= dt1 && x.Start < dt2).ToList().Sum(x => x.TotalSeconds);
            }
        }

        //     public SessionForNode ForNode(INode n)
        //     {
        //return new SessionForNode(n, _contextFactory);
        //     }

        public SessionForNode ForNode(int parentNode)
        {
            return new SessionForNode(parentNode, _contextFactory);
        }

        public IEnumerable<OSession> GetSessionExtraOf(int nodeId)
        {

            //         Console.WriteLine("start");
            //         using (var db = _contextFactory.Create())
            //{
            //             //var nodeId = 2091;
            //             var sessionQuery = from s in db.Sessions
            //             where (
            //                                   from t in db.Nodes
            //                                   where t.id == nodeId ||
            //                                         db.Nodes.Where(tp => tp.owner_id == t.id).Any(tp => tp.id == nodeId)
            //                                   select t.id
            //                                ).Contains(s.NodeId)
            //                                select s;

            //             Console.WriteLine(sessionQuery.Count());
            //             Console.WriteLine("finish");

            //             return sessionQuery.ToList();
            //         }

            //using (var db = _contextFactory.Create())
            //{
            //    var treePath = db.Nodes
            //     .Where(n => n.id == nodeId)
            //     .Select(n => new { n.id, n.owner_id, n.name })
            //     .Union(db.Nodes
            //         .Join(
            //             db.Nodes.Where(n => n.id == nodeId),
            //             t => t.owner_id,
            //             tp => tp.id,
            //             (t, tp) => new { t.id, t.owner_id, t.name }
            //         )
            //         .Join(
            //             db.Nodes.Where(n => n.id == nodeId),
            //             t => t.owner_id,
            //             tp => tp.id,
            //             (t, tp) => new { t.id, t.owner_id, t.name }
            //         )
            //         .Select(t => new { t.id, t.owner_id, t.name })
            //     )
            //     .Select(x => x.id)
            //     .ToList();

            //    foreach (var item in treePath)
            //    {
            //        Console.WriteLine($"{item}");
            //    }


            //    return db.Sessions
            //        .Where(s => treePath.Any(id => id == s.NodeId))
            //        .ToList();
            //}

            using (var db = _contextFactory.Create())
            {
                var ownerId = db.Database
                                .SqlQuery<Node>($@"
                                    WITH RECURSIVE tree_path AS (
                                      SELECT id, owner_id, name
                                      FROM Nodes
                                      WHERE id = {nodeId}
                                      UNION ALL
                                      SELECT t.id, t.owner_id, t.name
                                      FROM Nodes t
                                      JOIN tree_path tp ON t.owner_id = tp.id
                                    )
                                    SELECT id
                                    FROM tree_path")
                                .Select(n => n.id);

                var matchingSessions = db.Sessions
                    .Where(s => ownerId.Contains(s.NodeId))
                    .ToList();

                return matchingSessions;
            }

        }
    }
}
