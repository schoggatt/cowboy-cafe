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
        CardTerminal terminal = new CardTerminal();
        ReceiptPrinter printer = new ReceiptPrinter();

        /// <summary>
        /// Constructor for transaction control
        /// </summary>
        public TransactionControl()
        {
            InitializeComponent();
            CancelButton.Click += FinishOrder;
            CreditButton.Click += CreditButton_Click;
            CashButton.Click += CashButton_Click;
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

        /// <summary>
        /// Completes a credit transaction on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void CreditButton_Click(object sender, RoutedEventArgs arg)
        {
            if(DataContext is Order order)
            {
                switch(terminal.ProcessTransaction(order.Total))
                {
                    case ResultCode.Success:
                        printer.Print(order.Receipt(false, 0, 0));
                        FinishOrder(this, arg);
                        break;
                    case ResultCode.CancelledCard:
                        MessageBox.Show("ERROR: Cancelled Card");
                        break;
                    case ResultCode.ReadError:
                        MessageBox.Show("ERROR: Read Error");
                        break;
                    case ResultCode.InsufficentFunds:
                        MessageBox.Show("ERROR: Insuffucient Funds");
                        break;
                    default:
                        MessageBox.Show("ERROR: Unknown Error");
                        break;
                }
            }
        }

        /// <summary>
        /// Completes a cash transaction on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void CashButton_Click(object sender, RoutedEventArgs arg)
        {

        }
    }
}
