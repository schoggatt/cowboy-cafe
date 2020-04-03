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
    /// Interaction logic for CashTransaction.xaml
    /// </summary>
    public partial class CashTransaction : UserControl
    {
        public CashTransaction()
        {
            InitializeComponent();
            TenderButton.Click += TenderButton_Click;
        }

        private void TenderButton_Click(object sender, RoutedEventArgs args)
        {
            var screen = new OrderControl();
            this.Content = screen;
        }
    }
}
