using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FeBinder.Entities;

namespace FeBinder.Repositories
{
    class BinderContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public BinderContext() : base("DefaultConnection") {}
    }
}
