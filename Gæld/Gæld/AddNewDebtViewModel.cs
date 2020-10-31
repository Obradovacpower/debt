using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Gæld.Classes;
using Prism.Commands;
using Prism.Mvvm;

namespace Gæld
{
    class AddNewDebtViewModel : BindableBase
    {
        private UnitOfWork uow;
        public AddNewDebtViewModel()
        {
            uow = UnitOfWork.GetUnitOfWork();
        }
    }
}
