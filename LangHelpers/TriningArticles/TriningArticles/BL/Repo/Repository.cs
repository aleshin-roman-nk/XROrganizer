using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TriningArticles.BL.tools;

namespace TriningArticles.BL.Repo
{
	public class Repository : IRepository
	{
		string _dir;
		readonly string _conf_file = "config.json";
		private repo_config _config = null;
		//public Repository(string source_dir)
		public Repository()// если хочется пользоваться системной конфигурацией и 
		{
			//_dir = source_dir;
			//checkDirectory(_dir);
			//_config = load_config();
		}

		public void SetSourceDir(string dir)
		{
			_dir = dir;
			checkDirectory(_dir);
			_config = load_config();
		}

		public void Close()
		{
			save_config();
		}

		private string file_of_db(string file)
		{
			return $"{_dir}\\{file}";
		}

		private repo_config load_config()
		{
			var config_file = file_of_db(_conf_file);

			if (File.Exists(config_file))
			{
				return ObjectIO.Read<repo_config>(config_file);
			}

			return default_config();
		}

		private void save_config()
		{
			ObjectIO.Write(_config, file_of_db(_conf_file));
		}

		private repo_config default_config()
		{
			return new repo_config { last_id = 0 };
		}

		private void checkDirectory(string dir)
		{
			if (!Directory.Exists(dir))
			{
				Directory.CreateDirectory(dir);
			}
		}



		public IEnumerable<Article> GetAllArticles()
		{
			var names = Directory.GetFiles(_dir, "art*.json").OrderByDescending(x => x).Select(x => Path.GetFileName(x));

			List<Article> arts = new List<Article>();

			foreach (var item in names)
				arts.Add(LoadArticle(item));

			return arts.OrderByDescending(x=>x.Id);
		}
		public Article Create()
		{
			return new Article();
		}

		public void DeleteArticle(Article art)
		{
			var fname = file_of_db($"art{art.Id}.json");

			ObjectIO.Delete(fname);
		}

		public Article SaveArticle(Article art)
		{
			if (art.Id == 0) art.Id = ++_config.last_id;

			var fname = file_of_db($"art{art.Id}.json");

			ObjectIO.Write(art, fname);

			return art;
		}

		public Article LoadArticle(string fname)
		{
			return ObjectIO.Read<Article>(file_of_db(fname));
		}
	}
}
