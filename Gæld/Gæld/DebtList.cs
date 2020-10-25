using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;

namespace Gæld
{
    class DebtList: BindableBase
    {
        public ICommand _NewDebt;

        public ICommand NewDebt
        {
            get
            {
                return _NewDebt ?? (_NewDebt = new DelegateCommand(() =>
                {

                }));
            }
        } 
    }
}
