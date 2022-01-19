using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.UI.Interfaces.EventArgsDefinition
{
    public class SessionsPageRequiredEventArgs
    {
        public int page { get; }
        public int itemsPerPage { get; }
        public DateTime date { get; }
        public int taskId { get; }
        public SessionsPageRequiredEventArgs(
            int pge, 
            int itemsPerPge,
            DateTime dte, 
            int tskId)
        {
            page = pge;
            itemsPerPage = itemsPerPge;
            date = dte;
            taskId = tskId;
        }
    }
}
