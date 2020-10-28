using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gæld.Database.Models
{
    class PersonEntity
    {
        public int Id { get; set; }
        public List<DebtEntity> Debts { get; set; } = new List<DebtEntity>();
        public string Name { get; set; }

    }
}
