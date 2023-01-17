using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class NodeTextPage
    {
        public int id { get; set; }
        public int nodeid { get; set; }
        public string text { get; set; }
        public string title { get; set; }
    }
}
