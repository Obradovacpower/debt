using Gæld.Database.Models;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gæld.Classes
{
    class Person : BindableBase
    {
        private string name;
        private List<Debt> debtList;
        private int totalDebt;

        public Person(PersonEntity p)
        {
            debtList = new List<Debt>();
            name = p.Name;
            foreach(DebtEntity debt in p.Debts)
            {
                DebtList.Add(new Debt(debt));
                TotalDebt += debt.Amount;
            }
        }
        public int TotalDebt
        {
            get { return totalDebt; }
            private set { SetProperty(ref totalDebt, value); }
        }

        public List<Debt> DebtList
        {
            get { return debtList; }
            private set { SetProperty(ref debtList, value); }
        }
        public string Name
        {
            get { return name; }
            private set { SetProperty(ref name, value); }
        }
        
    }
}
