using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBank.Presenters.EventDefinition
{
    public class GetSessionsEvenArgs
    {
        public int taskId { get; }
        public DateTime Date { get; }
        public int page { get; }
        public int itemsPerPage { get; }
        public IEnumerable<OSession> Sessions { get; set; }

        public GetSessionsEvenArgs(
            int pge,
            int itemsPerPge,
            DateTime dte,
            int tskId
            )
        {
            taskId = tskId;
            Date = dte;
            page = pge;
            itemsPerPage = itemsPerPge;
        }
    }
}
