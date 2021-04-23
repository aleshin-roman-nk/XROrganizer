using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatMeDid.BL
{
	public enum NoteType { Task, Report }
	public class DayNote
	{
		public int Id { get; set; }
		public DateTime DateTime { get; set; }
		public string Body { get; set; }
		public NoteType NoteType { get; set; }
	}
}
