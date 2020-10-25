using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace Gæld
{
    class Mvvm : BindableBase
    {
        public ICommand _addNew;

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
