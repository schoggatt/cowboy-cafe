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

        public double Subtotal
        {
            get
            {
                double total = 0;
                foreach(IOrderItem item in Items)
                {
                    total += item.Price;
                }
                return total;
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
            if (orderList != null && orderList.Contains(item)) orderList.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }

        public void Remove(IOrderItem item)
        {
            if(orderList != null && orderList.Contains(item)) orderList.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
        }
    }
}
