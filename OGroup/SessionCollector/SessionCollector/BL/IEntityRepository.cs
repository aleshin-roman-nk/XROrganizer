using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.BL
{
	public interface IEntityRepository<TEntity>
	{
		IEnumerable<TEntity> Get();
		TEntity GetById(int id);
		void Delete(TEntity e);
		void Save(TEntity e);
	}
}