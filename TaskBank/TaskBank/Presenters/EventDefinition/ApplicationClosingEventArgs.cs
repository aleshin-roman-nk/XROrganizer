using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBank.Presenters.EventDefinition
{
    public class ApplicationClosingEventArgs
    {
        public bool AnyWorkingWindows { get; set; }
        public ApplicationClosingEventArgs()
        {
            AnyWorkingWindows = false;
        }
    }
}
