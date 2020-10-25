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
        public DbSet<Person> Persons { get; set; }
        public DbSet<Debt> Debts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Debt>()
                .HasOne(a => a.Person)
                .WithMany(b => b.Debts)
                .HasForeignKey(e => e.PersonId);

            modelBuilder.Entity<Person>()
                .HasData(
                new Person { Id = 1, Name = "Carsten" },
                new Person { Id = 2, Name = "Sebastian" },
                new Person { Id = 3, Name = "Ermin Jensen"},
                new Person { Id = 4, Name = "Rayquaza" });
            modelBuilder.Entity<Debt>()
                .HasData(
                new Debt { Id = 1, PersonId = 1, Amount = -30, Date = DateTime.Now },
                new Debt { Id = 2, PersonId = 1, Amount = -15, Date = DateTime.Now },
                new Debt { Id = 3, PersonId = 1, Amount = 19, Date = DateTime.Now },
                new Debt { Id = 4, PersonId = 2, Amount = 5000, Date = DateTime.Now},
                new Debt { Id = 5, PersonId = 3, Amount = -5000, Date = DateTime.Now.AddDays(-30)},
                new Debt { Id = 6, PersonId = 4, Amount = 1234, Date = DateTime.Now.AddDays(-15)});

        }
    }
}