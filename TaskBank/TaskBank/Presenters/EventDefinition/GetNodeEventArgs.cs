using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBank.Presenters.EventDefinition
{
    public class GetNodeEventArgs
    {
        public bool NodeExists { get; set; }
        public Node Node { get; set; }
        public int nodeId { get; }
        public GetNodeEventArgs(int tskId)
        {
            nodeId = tskId;
        }
    }
}
