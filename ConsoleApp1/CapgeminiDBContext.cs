using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CapgeminiDBContext:DbContext
    {
        public DbSet<Employe> employes { get; set; }
    }
}
