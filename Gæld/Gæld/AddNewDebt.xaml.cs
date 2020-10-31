using Gæld.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gæld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AddNewDebt : Window
    {
        private UnitOfWork uow;
        public AddNewDebt()
        {
            InitializeComponent();
            uow = UnitOfWork.GetUnitOfWork();
        }
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            uow.AddPerson(tbName.Text, int.Parse(tbAmount.Text));
            this.Close();
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
