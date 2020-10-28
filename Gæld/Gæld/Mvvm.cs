using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Gæld.Database.Models;
using Prism.Commands;
using Prism.Mvvm;

namespace Gæld
{
    class Mvvm : BindableBase
    {
        public static ObservableCollection<Person> persons = new ObservableCollection<Person>();

        public ICommand _addNew;

        private Person _currentPerson = null;
        private int _currentIndex = 0;

        public ObservableCollection<Person> Persons
        {
            get { return persons; }
            set
            {
                SetProperty(ref persons, value);
            }
        }

        public Person CurrentPerson
        {
            get { return _currentPerson; }
            set { SetProperty(ref _currentPerson, value); }
        }

        public int CurrentIndex
        {
            get { return _currentIndex; }
            set { SetProperty(ref _currentIndex, value); }
        } 


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
