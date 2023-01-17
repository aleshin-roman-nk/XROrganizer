using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.dto
{
	public class NodeDTO
	{
		public int id { get; set; }
		public NType type { get; set; }
		public string name { get; set; }
		public string NTypeString { get { return type.ToString(); } }
		public string path { get; set; }
		public bool pinned { get; set; }
        public DateTime? date { get; set; }
        public bool IsCompleted { get; set; }
        //public int owner_id { get; set; }

        private static NodeDTO _root = null;
        private static NodeDTO _exit_top = null;
        public static NodeDTO Root
        {
            get
            {
                if (_root == null)
                    _root = new NodeDTO { id = 0, type = NType._sys_root_dir, name = "" };

                return _root;
            }
        }
        public static NodeDTO ExitTopDir
        {
            get
            {
                if (_exit_top == null)
                    _exit_top = new NodeDTO { id = -1, type = NType.exit_dir, name = ".." };

                return _exit_top;
            }
        }
    }
}
