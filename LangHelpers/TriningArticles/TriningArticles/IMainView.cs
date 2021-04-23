using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriningArticles.BL;

namespace TriningArticles
{
	public interface IMainView
	{
		event Action<Article> SaveArticle;
		event Action<Article> DeleteArticle;
		event Action<string> ArticleSelected;

		void PutArticleNameList(IEnumerable<Article> arts);
		void PutArticle(Article art);
	}
}
