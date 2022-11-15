using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EF_Code_First_Approach.Models;

namespace EF_Code_First_Approach.Data
{
    public class EF_Code_First_ApproachContext : DbContext
    {
        public EF_Code_First_ApproachContext (DbContextOptions<EF_Code_First_ApproachContext> options)
            : base(options)
        {
        }

        public DbSet<EF_Code_First_Approach.Models.Mobile> Mobile { get; set; } = default!;
    }
}
