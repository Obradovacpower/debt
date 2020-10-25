using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gæld.Database.Models
{
    class Debt
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public int PersonId { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
