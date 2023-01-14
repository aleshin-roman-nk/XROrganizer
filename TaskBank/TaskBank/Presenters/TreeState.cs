using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBank.Presenters
{
    public class TreeState
    {
        public IEnumerable<INode> Children { get; set; }
        public Stack<INode> Parents { get; set; } = new Stack<INode>();
        public INode NodeUnderCursor { get; set; }
    }
}
