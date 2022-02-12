using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBank.Presenters.EventDefinition
{
    public class RequestFTaskOpenObjectManagerEventArgs
    {
        public bool NodeExists { get; set; }
        public Node Node { get; set; }
        public int taskId { get; }
        public RequestFTaskOpenObjectManagerEventArgs(int tskId)
        {
            taskId = tskId;
        }
    }
}
