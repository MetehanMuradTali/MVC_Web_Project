using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public  class Context: DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<New> News { get; set; }
        public DbSet<Poem> Poems { get; set; }
    }
}
