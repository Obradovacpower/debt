using Gæld.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gæld.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace Gæld.Classes
{
    class UnitOfWork 
    {
        protected readonly Repository<Person> persons;
        protected readonly Repository<Debt> debts;
        public UnitOfWork(Repository<Person> p, Repository<Debt> d)
        {
            persons = p;
            debts = d;
        }

        public void AddPerson(string name)
        {
            Person p = new Person();
            p.Name = name;
            p.Debts = new List<Debt>();

            persons.Add(p);
        }
        public void AddDebt(int amount, int personId)
        {
            Debt d = new Debt();
            d.Amount = amount;
            d.Date = DateTime.Now;
            debts.Add(d);

            Person p = persons.Get(personId);
            p.Debts.Add(d);
            persons.Update(p);
        }
        public void AddDebt(int amount, Person p)
        {
            Debt d = new Debt();
            d.Amount = amount;
            d.Date = DateTime.Now;
            debts.Add(d);

            p.Debts.Add(d);
            persons.Update(p);
        }

    }
}
