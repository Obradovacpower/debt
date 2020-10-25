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
            //ob.UseSqlServer(@"Data Source=localhost,1433;Database=vareDatabase;User ID=SA;Password=SecPass1;");
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Debt> Debts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Debt>()
                .HasOne(a => a.Person)
                .WithMany(b => b.Debts)
                .HasForeignKey(e => e.PersonId);

        }
    }
}