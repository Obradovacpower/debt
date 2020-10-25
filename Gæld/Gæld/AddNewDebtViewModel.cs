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
    class AddNewDebtViewModel
    {
        public ICommand _Cancel;

        public ICommand Cancel
        {
            get
            {
                return _Cancel ?? (_Cancel = new DelegateCommand(() =>
                {
                    
                }
                ));
            }
        }
    }
}
