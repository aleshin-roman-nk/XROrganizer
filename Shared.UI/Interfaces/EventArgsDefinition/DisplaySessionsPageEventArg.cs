using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.UI.Interfaces.EventArgsDefinition
{
    public class DisplaySessionsPageEventArg: EventArgs
    {
        public DateTime Date { get; }
        public string fullPath { get; }
        public int taskId { get; }

        public DisplaySessionsPageEventArg(DateTime d, string fp, int tskId)
        {
            Date = d;
            fullPath = fp;
            taskId = tskId;
        }
    }
}
