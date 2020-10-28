using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gæld.Database.Models;

namespace Gæld.Classes
{
    class Debt : BindableBase
    {
        public Debt() { }
        private DateTime date;
        private int amount;

        public DateTime Date
        {
            get { return Date; }
            private set { SetProperty(ref date, value); }
        }
        public int Amount
        {
            get { return amount; }
            private set { SetProperty(ref amount, value); }
        }
        public Debt(DebtEntity d)
        {
            date = d.Date;
            amount = d.Amount;
        }
    }
}
