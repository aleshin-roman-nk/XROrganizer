using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.Presenters
{
    public class ExtendSessionTomorrowEventArgs
    {
        public int taskId { get; }
        public DateTime Today { get; }

        public ExtendSessionTomorrowEventArgs(int id, DateTime d)
        {
            taskId = id;
            Today = d;
        }
    }
}
