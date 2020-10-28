using Gæld.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gæld.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Gæld.Database
{
    class PersonRepository : Repository<PersonEntity>
    {
        protected readonly DbContext db;
        public PersonRepository(DebtBookContext db) : base(db)
        {
            this.db = db;
        }
        public List<PersonEntity> GetInclude()
        {
            return context.Set<PersonEntity>().Include(i => i.Debts).ToList();
        }
    }
}
