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
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();

            //Set up data context for the associated elements

            var order = new Order();
            this.DataContext = order;

            //Add event handlers for buttons

            CompleteOrderButton.Click += CompleteOrderButton_Click;
            CancelOrderButton.Click += CancelOrderButton_Click;
        }

        /// <summary>
        /// Makes a new order on click and sets it to the data context
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void CompleteOrderButton_Click(object sender, RoutedEventArgs arg)
        {
            this.DataContext = new Order();
        }

        /// <summary>
        /// Makes a new order on click and set it to the data context
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        private void CancelOrderButton_Click(object sender, RoutedEventArgs arg)
        {
            this.DataContext = new Order();
        }
    }
}

