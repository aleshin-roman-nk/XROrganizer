using Domain.Entities;
using Shared.UI.Interfaces.EventArgsDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.UI.Interfaces
{
    public interface ITopSessionsOfTaskView
    {
        void Go(string path, DateTime d, int taskId);
        void Display(IEnumerable<OSession> sessions);
        event EventHandler Completed;
        event EventHandler<SessionsPageRequiredEventArgs> PageChanged;
    }
}