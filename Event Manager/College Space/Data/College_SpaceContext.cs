using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using College_Space.Models;

namespace College_Space.Data
{
    public class College_SpaceContext : DbContext
    {
        public College_SpaceContext (DbContextOptions<College_SpaceContext> options)
            : base(options)
        {
        }

        public DbSet<College_Space.Models.Event> Events { get; set; } = default!;
    }
}
