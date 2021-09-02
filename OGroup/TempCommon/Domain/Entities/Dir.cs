using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	[Table("Dirs")]
	public class Dir : Node
	{
		public Dir()
		{
			_type = NType.Dir;
			_canHaveChildren = true;
		}

		private static Dir _root = null;
		private static Dir _exit_top = null;
		public static Dir Root
		{
			get
			{
				if (_root == null)
					_root = new Dir { id = 0, _type = NType._sys_root_dir, name = "" };

				return _root;
			}
		}
		public static Dir ExitTopDir
		{
			get
			{
				if (_exit_top == null)
					_exit_top = new Dir { id = -1, _type = NType.exit_dir, name = ".." };

				return _exit_top;
			}
		}
	}
}
