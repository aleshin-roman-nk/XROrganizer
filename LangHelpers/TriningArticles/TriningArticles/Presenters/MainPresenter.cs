using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriningArticles.BL;
using TriningArticles.BL.Repo;

namespace TriningArticles.Presenters
{
	public class MainPresenter
	{
		private readonly IMainView view;
		private readonly IRepository repo;

		public MainPresenter(IMainView view, IRepository repository)
		{
			this.view = view;
			this.repo = repository;
		}
	}
}
