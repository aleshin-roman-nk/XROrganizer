using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TriningArticles.BL
{
	public class ArticleService
	{
		Article _article;

		public void SetObject(Article a)
		{
			_article = a;
		}

		public int SentensesCount(string text)
		{
			Regex r = new Regex(@"(\.\s)|(\.\w)|(\?\w)|(\?\s)|(\.$)|(\.\n)|(\!\s)");
			return r.Matches(text).Count;
		}

		public string maches()
		{
			Regex r = new Regex(@"(\.\s)|(\.\w)|(\?\w)|(\?\s)|(\.$)|(\.\n)|(\!\s)");
			var m = r.Matches(_article.WorkText);
			StringBuilder res = new StringBuilder();
			foreach (Match item in m)
				res.Append($"<{item.Value}>");

			res.Append('\n');
			res.Append(_article.WorkText);

			return res.ToString();
		}

		public void Clear()
		{
			_article = null;
		}
	}
}
