using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Sales
{
    class SalesDataContext: DbContext
    {
        public DbSet<ResultT4> Results { get; set; }
    }
}
