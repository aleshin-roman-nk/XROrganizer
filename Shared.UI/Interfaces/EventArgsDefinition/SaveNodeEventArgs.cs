using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.UI.Interfaces.EventArgsDefinition
{
    public class SaveNodeEventArgs
    {
        public INode Node { get; private set; }
        public bool IsNodeSaved { get; set; }

        public SaveNodeEventArgs(INode n)
        {
            Node = n;
            IsNodeSaved = false;
        }
    }
}
