using Domain.Entities;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repos
{
	public interface INoteRepository: IObservableCollection<Note>, IRepository<Note>
	{
	}
}
