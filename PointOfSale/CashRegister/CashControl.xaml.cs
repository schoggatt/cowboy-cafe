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
    public partial class CashControl : UserControl
    {
        private Order order;

        /// <summary>
        /// Constructor for a CashRegisterControl
        /// </summary>
        /// <param name="order"></param>
        public CashControl(Order order)
        {
            InitializeComponent();
            this.DataContext = new UserCashInputModelView();
            this.order = order;
            TotalNeeded.Loaded += OrderTotal_Initialized;
            GetChange.Click += GetChange_Click;
        }

        /// <summary>
        /// Initializes the order total text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void OrderTotal_Initialized(object sender, EventArgs arg)
        {
            TotalNeeded.Text = string.Format("Total: ${0:#0.00}", order.Total);
        }

        /// <summary>
        /// Flips the screen to get change for the customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void GetChange_Click(object sender, EventArgs arg)
        {
            if (DataContext is UserCashInputModelView customerView)
            {
                double orderCost = Math.Round(order.Total, 2);
                double registerValue = Math.Round(customerView.TotalValue, 2);
                if (registerValue >= orderCost)
                {
                    var screen = new ChangeControl(customerView, order);
                    this.Content = screen;
                }
                else
                {
                    MessageBox.Show("ERROR: Insuffucient Cash");
                }
            }
        }
    }
}
