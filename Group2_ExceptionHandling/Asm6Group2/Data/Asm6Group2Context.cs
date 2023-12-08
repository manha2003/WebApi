using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asm6Group2.Models;

namespace Asm6Group2.Data
{
    public class Asm6Group2Context : DbContext
    {
        public Asm6Group2Context (DbContextOptions<Asm6Group2Context> options)
            : base(options)
        {
        }

        public DbSet<Asm6Group2.Models.Student> Student { get; set; } = default!;
    }
}
