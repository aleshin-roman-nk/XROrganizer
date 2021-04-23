using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatMeDid.Tools;

namespace WhatMeDid.BL
{
	/*
	 * Here I have done a mistake. I should not have to change this class. I should have made other class, that transforms data.
	 * I broke open close principle.
	 * 
	 */

	public class Repository
	{
		string db_config_file = "db_config.json";
		configParams par;

		public Repository()
		{
			load_parameters();
		}
		void load_parameters()
		{
			if (!File.Exists(db_config_file)) 
			{ 
				par = new configParams();
				return;
			}

			par = configParams.Load(db_config_file);
		}
		void save_parametres()
		{
			par.Save(db_config_file);
		}

		public void SaveReports(ReportCollection o, string filename)
		{
			string j = Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);
			File.WriteAllText(filename, j, Encoding.UTF8);
		}
		public ReportCollection LoadReports(string filename)
		{
			if (!File.Exists(filename))
			{
				return new ReportCollection();
			}

			string j = File.ReadAllText(filename, Encoding.UTF8);
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ReportCollection>(j);
		}
		public void SaveTasks(TaskCollection o, string filename)
		{
			string j = Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);
			File.WriteAllText(filename, j, Encoding.UTF8);
		}
		public TaskCollection LoadTasks(string filename)
		{
			if (!File.Exists(filename))
			{
				return new TaskCollection();
			}

			string j = File.ReadAllText(filename, Encoding.UTF8);
			return Newtonsoft.Json.JsonConvert.DeserializeObject<TaskCollection>(j);
		}

		string make_name_from_daynote(NoteType t, DateTime dt)
		{
			var y = dt.Year;
			var m = dt.Month;
			var d = dt.Day;

			return $"{t}_{y}_{m:d2}_{d:d2}.json";
		}

		public void SaveNote(DayNote n, string dirname)
		{
			var fname = make_name_from_daynote(n.NoteType, n.DateTime);

			var content = MyJson.ToString(n);

			File.WriteAllText($"{dirname}\\{fname}", content, Encoding.UTF8);
		}

		public DayNote LoadNote()
		{
			throw new NotImplementedException();
		}

		public DayNote CreateNote(NoteType t, DateTime d)
		{
			throw new NotImplementedException();
		}

		public DayNote GetNote(NoteType t, DateTime d)
		{
			string note_f_name = make_name_from_daynote(t, d);
			throw new NotImplementedException();
		}

		public void TransformIntoPiecesTasks(TaskCollection t, string dest_dir_name)
		{
			if(!Directory.Exists(dest_dir_name))
			 Directory.CreateDirectory(dest_dir_name);

			foreach (var item in t.Tasks)
			{
				DayNote n = new DayNote { Body = item.Body, NoteType = NoteType.Task, DateTime = item.DateTime, Id = item.Id };
				SaveNote(n, dest_dir_name);
			}
		}

		public void TransformIntoPiecesReports(ReportCollection r, string dest_dir_name)
		{
			if (!Directory.Exists(dest_dir_name))
				Directory.CreateDirectory(dest_dir_name);

			foreach (var item in r.Reports)
			{
				DayNote n = new DayNote { Body = item.Body, NoteType = NoteType.Report, DateTime = item.DateTime, Id = item.Id };
				SaveNote(n, dest_dir_name);
			}
		}
	}
}
