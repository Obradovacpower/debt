using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gæld.Database.Models
{
    class Person
    {
        public int Id { get; set; }
        public List<Debt> Debts { get; set; } = new List<Debt>();
        public string Name { get; set; }

    }
}
