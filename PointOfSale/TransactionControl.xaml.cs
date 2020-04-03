using CashRegister;
using CowboyCafe.Data;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {

        public TransactionControl()
        {
            InitializeComponent();
            CancelButton.Click += FinishOrder;
        }

        /// <summary>
        /// Makes a new orderControl on click and sets it to the data context
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void FinishOrder(object sender, RoutedEventArgs arg)
        {
            var screen = new OrderControl();
            this.Content = screen;
        }

        private void CreditButton_Click(object sender, RoutedEventArgs arg)
        {

        }

        private void CashButton_Click(object sender, RoutedEventArgs arg)
        {

        }
    }
}
