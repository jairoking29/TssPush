using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TssPush.Models
{
    class TssDb : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public TssDb() : base("default")
        { }
    }
}
