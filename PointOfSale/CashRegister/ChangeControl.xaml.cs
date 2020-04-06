using CashRegister;
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
    /// Interaction logic for ChangeControl.xaml
    /// </summary>
    public partial class ChangeControl : UserControl
    {
        private UserCashInputModelView customerView;
        private Order order;

        /// <summary>
        /// Constructor for a new ChangeControl
        /// </summary>
        /// <param name="customerView"></param>
        /// <param name="order"></param>
        public ChangeControl(UserCashInputModelView customerView, Order order)
        {
            
            InitializeComponent();
            this.order = order;
            this.customerView = customerView;
            UserCashInputModelView context = new UserCashInputModelView();
            context.isCustomerInput = false;
            this.DataContext = context;
            TotalNeeded.Loaded += OrderTotal_Initialized;
            TenderButton.Click += TenderButton_Click;
        }

        /// <summary>
        /// Initializes the order total text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void OrderTotal_Initialized(object sender, EventArgs arg)
        {
            TotalNeeded.Text = string.Format("Change Needed: ${0:#0.00}", customerView.TotalValue - order.Total);
        }

        /// <summary>
        /// Tenders the transaction on button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void TenderButton_Click(object sender, EventArgs arg)
        {
            double change = Math.Round(customerView.TotalValue - order.Total, 2);
            if(DataContext is UserCashInputModelView employeeView)
            {
                double calculated = Math.Round(employeeView.TotalValue * -1, 2);
                if (calculated == change)
                {
                    ReceiptPrinter printer = new ReceiptPrinter();
                    printer.Print(order.Receipt(true, customerView.TotalValue, change));
                    var screen = new OrderControl();
                    this.Content = screen;
                }
                else
                {
                    MessageBox.Show("ERROR: Insuffucient Change");
                }
            }
        }
    }
}
