using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gæld.Database.Models
{
    class DebtEntity
    {
        public int Id { get; set; }
        public PersonEntity Person { get; set; }
        public int PersonId { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
