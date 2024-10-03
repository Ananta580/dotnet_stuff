using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using A1_2.Models;

namespace A1_2.Data
{
    public class A1_2Context : DbContext
    {
        public A1_2Context (DbContextOptions<A1_2Context> options)
            : base(options)
        {
        }

        public DbSet<A1_2.Models.Resource> Resource { get; set; } = default!;

        public DbSet<A1_2.Models.Project> Project { get; set; } = default!;
    }
}
