using System.Collections.Generic;

namespace TriningArticles.BL.Repo
{
	public interface IRepository
	{
		void Close();
		Article Create();
		void DeleteArticle(Article art);
		IEnumerable<Article> GetAllArticles();
		Article LoadArticle(string fname);
		Article SaveArticle(Article art);
	}
}