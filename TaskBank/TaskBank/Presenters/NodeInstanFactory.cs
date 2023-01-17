using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBank.Presenters
{
    public class NodeInstanFactory
    {
        Dictionary<string, Func<INode>> members = new Dictionary<string, Func<INode>>();

        public void AddNodeType<NType>()
            where NType : INode, new()
        {
            var t = typeof(NType);
            members.Add(t.Name, () => new NType());
        }

        public void AddNodeType<NType>(Func<INode> customCreator)
            where NType : INode, new()
        {
            var t = typeof(NType);
            members.Add(t.Name, customCreator);
        }

        public INode CreateNode(string tname)
        {
            var act = members.Keys.FirstOrDefault(x => x.Equals(tname));

            if (string.IsNullOrEmpty(act)) throw new InvalidOperationException($"Request name {tname} is not recognized");

            return members[tname]();
        }

        public IEnumerable<string> Members => members.Select(x => x.Key);
    }
}
