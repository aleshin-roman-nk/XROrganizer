using SessionCollector.BL.Db;
using SessionCollector.BL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.BL
{
	public class DirectoryRepository : IEntityRepository<ODirectory>
	{
		AppData _appData;

		public DirectoryRepository(AppData data)
		{
			_appData = data;
		}

		public void Delete(ODirectory e)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ODirectory> Get()
		{
			throw new NotImplementedException();
		}

		public ODirectory GetById(int id)
		{
			throw new NotImplementedException();
		}

		public void Save(ODirectory e)
		{
			throw new NotImplementedException();
		}
	}
}
