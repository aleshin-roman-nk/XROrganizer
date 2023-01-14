using Domain.DBContext;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Repos
{
    public class ForParentNode
    {
        private readonly INode _parentNode;
        private readonly IAppDataContextFactory dbFactory;

        public ForParentNode(INode n, IAppDataContextFactory dbFactory)
        {
            this._parentNode = n;
            this.dbFactory = dbFactory;
        }

        public INode Create(INode n)
        {
            using (var db = dbFactory.Create())
            {
                n.owner_id = _parentNode.type == Enums.NType._sys_root_dir ? 0 : _parentNode.id;

                db.Entry(n).State = EntityState.Added;
                db.SaveChanges();

                n.DNA = _parentNode.type == Enums.NType._sys_root_dir ? $"-{n.id}-" : $"{_parentNode.DNA}{n.id}-";

                db.Entry(n).Property(x => x.DNA).IsModified = true;
                db.SaveChanges();
            }

            return n;
        }

        public void Move(IEnumerable<INode> nodes)//мы ведь из другого контекста вытащили эту коллекцию
        {

            using (var db = dbFactory.Create())
            {
                Func<INode, IEnumerable<INode>> getChildren = (parent) =>
                {
                    return db.Nodes
                        .Where(x => x.owner_id == parent.id)
                        //.Select(x => new Node { id = x.id, DNA = x.DNA })
                        .ToList();
                };

                // корневые узлы
                foreach (var node in nodes)
                {

                    db.Nodes.Attach((Node)node);
                    node.DNA = _parentNode.type == Enums.NType._sys_root_dir ? $"-{node.id}-" : $"{_parentNode.DNA}{node.id}-";
                    node.owner_id = _parentNode.type == Enums.NType._sys_root_dir ? 0 : _parentNode.id;
                    db.Entry(node).Property(x => x.DNA).IsModified = true;
                    db.Entry(node).Property(x => x.owner_id).IsModified = true;
                    _updateSessionsDNA(node, db);

                    var parentsStack = new Stack<INode>();

                    parentsStack.Push(node);

                    // одно поколение узлов должно брать днк из предидущего поколения узлов
                    while (parentsStack.Any())
                    {
                        var thisParent = parentsStack.Pop();// текущий родитель

                        // обход всех дочерних объектов и обновление днк
                        foreach (var child in getChildren(thisParent))
                        {
                            child.DNA = $"{thisParent.DNA}{child.id}-";
                            db.Entry(child).Property(x => x.DNA).IsModified = true;
                            _updateSessionsDNA(child, db);

                            parentsStack.Push(child);
                        }
                    }

                }

                db.SaveChanges();
            }
        }

        private void _updateSessionsDNA(INode node, AppData db)
        {
            var sessions = db.Sessions.Where(x => x.NodeId == node.id).ToList();

            foreach (var item in sessions)
            {
                item.DNA = node.DNA;
                db.Entry(item).Property(x => x.DNA).IsModified= true;
            }
        }

        public IEnumerable<OSession> GetTopSessions(DateTime today, int top, int page)
        {
            DateTime dt1 = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0);
            DateTime dt2 = dt1.AddDays(1);

            using (var db = dbFactory.Create())
            {
                return db.Sessions.Where(sess =>
                    sess.NodeId == _parentNode.id && (sess.Start < dt2)
                ).OrderByDescending(sess => sess.Start).Skip(top * page).Take(top).ToList();
            };
        }
    }
}
