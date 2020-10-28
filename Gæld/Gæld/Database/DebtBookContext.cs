using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Gæld.Database.Models;

namespace Gæld.Database
{
    class DebtBookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder ob)
        {
            ob.UseSqlServer(@"Data Source=localhost,1433;Database=testDB;User ID=SA;Password=SecPass1;");
        }
        public DbSet<PersonEntity> Persons { get; set; }
        public DbSet<DebtEntity> Debts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<DebtEntity>()
                .HasOne(a => a.Person)
                .WithMany(b => b.Debts)
                .HasForeignKey(e => e.PersonId);

            modelBuilder.Entity<PersonEntity>()
                .HasData(
                new PersonEntity { Id = 1, Name = "Carsten" },
                new PersonEntity { Id = 2, Name = "Sebastian" },
                new PersonEntity { Id = 3, Name = "Ermin Jensen"},
                new PersonEntity { Id = 4, Name = "Rayquaza" });
            modelBuilder.Entity<DebtEntity>()
                .HasData(
                new DebtEntity { Id = 1, PersonId = 1, Amount = -30, Date = DateTime.Now },
                new DebtEntity { Id = 2, PersonId = 1, Amount = -15, Date = DateTime.Now },
                new DebtEntity { Id = 3, PersonId = 1, Amount = 19, Date = DateTime.Now },
                new DebtEntity { Id = 4, PersonId = 2, Amount = 5000, Date = DateTime.Now},
                new DebtEntity { Id = 5, PersonId = 3, Amount = -5000, Date = DateTime.Now.AddDays(-30)},
                new DebtEntity { Id = 6, PersonId = 4, Amount = 1234, Date = DateTime.Now.AddDays(-15)});

        }
    }
}