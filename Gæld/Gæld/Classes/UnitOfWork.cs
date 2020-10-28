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
        protected readonly PersonRepository persons;
        protected readonly Repository<DebtEntity> debts;
        public UnitOfWork(PersonRepository p, Repository<DebtEntity> d)
        {
            persons = p;
            debts = d;
        }

        public void AddPerson(string name)
        {
            PersonEntity p = new PersonEntity();
            p.Name = name;
            p.Debts = new List<DebtEntity>();

            persons.Add(p);
        }
        public List<Person> GetPersons()
        {
            List<Person> newper = new List<Person>();
            foreach(PersonEntity person in persons.Get())
            {
                newper.Add(new Person(person));
            }
            return newper;
        }
        public void AddDebt(int amount, int personId)
        {
            DebtEntity d = new DebtEntity();
            d.Amount = amount;
            d.Date = DateTime.Now;
            debts.Add(d);

            PersonEntity p = persons.Get(personId);
            p.Debts.Add(d);
            persons.Update(p);
        }
        public void AddDebt(int amount, PersonEntity p)
        {
            DebtEntity d = new DebtEntity();
            d.Amount = amount;
            d.Date = DateTime.Now;
            debts.Add(d);

            p.Debts.Add(d);
            persons.Update(p);
        }

    }
}
