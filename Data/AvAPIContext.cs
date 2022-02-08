using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AvAPI.Models;

namespace AvAPI.Data
{
    public class AvAPIContext : DbContext
    {
        public AvAPIContext (DbContextOptions<AvAPIContext> options)
            : base(options)
        {
        }

        public DbSet<AvAPI.Models.Jogador> Jogador { get; set; }
    }
}
