using Microsoft.EntityFrameworkCore;
using PoolParty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolParty.Data
{
    public class GestionTachesContext : DbContext 
    {
        public DbSet<Competition> Competition { get; set; }
        public DbSet<Equipe> Equipe { get; set; }
        public DbSet<Etape> Etape { get; set; }
        public DbSet<Jeu> Jeu { get; set; }
        public DbSet<Licensie> Licensie { get; set; }
        public DbSet<Rencontre> Rencontre { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GestionTachesDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Etape>()
                .HasOne(a => a.Rencontre)
                .WithOne(b => b.Etape)
                .HasForeignKey<Rencontre>(b => b.EtapeID);
        }



    }
}
