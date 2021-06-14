using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BioFresh.Models;

namespace BioFresh.Data
{
    public class BioFreshContext : DbContext
    {
        public BioFreshContext (DbContextOptions<BioFreshContext> options)
            : base(options)
        {
        }

        public DbSet<BioFresh.Models.Client> Client { get; set; }

        public DbSet<BioFresh.Models.Meniu> Meniu { get; set; }

        public DbSet<BioFresh.Models.Comanda> Comanda { get; set; }

        public DbSet<BioFresh.Models.Livrare> Livrare { get; set; }

        public DbSet<BioFresh.Models.Recenzie> Recenzie { get; set; }
    }
}
