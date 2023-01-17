using Domain.Entities;
using Shared.UI.Interfaces.EventArgsDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.UI.Interfaces
{
    public interface INodeDefaultView
    {
        event EventHandler<SaveNodeEventArgs> Save;
        event EventHandler Completed;
        event EventHandler<NodeTextPage> DeleteNodeTextPage;
        event EventHandler<int> OpenNodeById;

        int ObjId { get; }

        void Restore();
        void Go(INode o);
    }
}
