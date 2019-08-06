using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Model
{
    using System.Data.Entity;

    class RepositorySampleContext : DbContext
    {
        public RepositorySampleContext() : base("RepositorySampleContext") { }

        public DbSet<People> Peoples { get; set; }
        public DbSet<Device> Devices { get; set; }
    }
}
