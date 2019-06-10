using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TesteGT4W.Models
{
    public class TesteGT4WContext : DbContext
    {
        public TesteGT4WContext (DbContextOptions<TesteGT4WContext> options)
            : base(options)
        {
        }

        public DbSet<TesteGT4W.Models.Pessoa> Pessoa { get; set; }
    }
}
