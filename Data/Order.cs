using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        private static uint orderNumberTracker = 0;

        public event PropertyChangedEventHandler PropertyChanged;

        private double subtotal = 0;

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

        List<IOrderItem> orderList = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items
        {
            get
            {
                return orderList.ToArray();
            }
        }

        public uint OrderNumber
        {
            get
            {
                return orderNumberTracker++;
            }
        }

        public void Add(IOrderItem item)
        {
            subtotal += item.Price;
            orderList.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public void Remove(IOrderItem item)
        {
            if (orderList != null && orderList.Contains(item)) orderList.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
