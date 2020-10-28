﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Gæld.Classes;
using Gæld.Database;
using Gæld.Database.Models;
using Prism.Commands;
using Prism.Mvvm;

namespace Gæld
{
    class Mvvm : BindableBase
    {
        private static ObservableCollection<Person> persons;
        private static UnitOfWork uow;
        public Mvvm()
        {
            DebtBookContext db = new DebtBookContext();
            Repository<PersonEntity> p = new Repository<PersonEntity>(db);
            Repository<DebtEntity> d = new Repository<DebtEntity>(db);
            uow = new UnitOfWork(p, d);
            persons = new ObservableCollection<Person>(uow.GetPersons());
        }
        private ICommand _addNew;

        public ICommand addNew
        {
            get
            {
                return _addNew ?? (_addNew = new DelegateCommand(() =>
                {
                    AddNewDebt a = new AddNewDebt();
                    a.Show();
                }));
            }
        }
    }
}
