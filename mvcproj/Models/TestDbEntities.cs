using mvcproj.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace mvcproj.Models
{
    
    public class TestDbEntities : DbContext
    {

        public DbSet<Student> students { get; set; }

    }
}
