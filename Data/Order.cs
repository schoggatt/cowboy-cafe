using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Order class to store menu item objects
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Stores the overall order number of all orders
        /// </summary>
        private static uint orderNumberTracker = 0;

        /// <summary>
        /// Handler for when properties change in this class
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public Order()
        {
            orderNumberTracker++;
        }

        /// <summary>
        /// The total of all prices for items in this object
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0;
                foreach (IOrderItem item in Items)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        /// <summary>
        /// The total plus tax added for this object
        /// </summary>
        public double Total
        {
            get
            {
                return Subtotal + (Subtotal * .16);
            }
        }

        /// <summary>
        /// List of menu items stored in a list
        /// </summary>
        List<IOrderItem> orderList = new List<IOrderItem>();
        public IEnumerable<IOrderItem> Items
        {
            get
            {
                return orderList.ToArray();
            }
        }

        /// <summary>
        /// Returns the order number after incrementing it
        /// </summary>
        public uint OrderNumber
        {
            get
            {
                return orderNumberTracker;
            }
        }

        /// <summary>
        /// Returns an order string to print for the XAML code
        /// </summary>
        public string OrderString
        {
            get
            {
                return "Order " + OrderNumber.ToString();
            }
        }

        /// <summary>
        /// Adds a item to the list
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            orderList.Add(item);
            if(item is INotifyPropertyChanged pcItem) pcItem.PropertyChanged += OnItemChanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Removes an item from the list
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            orderList.Remove(item);
            if (item is INotifyPropertyChanged pcItem) pcItem.PropertyChanged -= OnItemChanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        private void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }
    }
}
