using CowboyCafe.Data;
using CowboyCafe.Data.Transactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale.CashRegister
{
    /// <summary>
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : UserControl
    {
        public CashRegisterControl()
        {
            InitializeComponent();
            TenderButton.Click += TenderButton_Click;
            this.DataContext = new CashRegisterModelView();
        }

        public void TenderButton_Click(object sender, RoutedEventArgs args)
        {
            var screen = new OrderControl();
            this.Content = screen;
        }
    }
}
