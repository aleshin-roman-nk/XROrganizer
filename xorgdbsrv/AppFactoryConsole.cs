using Domain.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xorgdbsrv
{
    internal class AppFactoryConsole : IAppDataContextFactory
    {
        private readonly string fname;

        public AppFactoryConsole(string fname)
        {
            this.fname = fname;
        }

        public AppData Create()
        {
            AppData res = new AppData(fname);
            //res.Database.Log = Logger.Write;
            return res;
        }
    }
}
