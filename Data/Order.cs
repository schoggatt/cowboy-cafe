using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
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
                return orderList;
            }
        }

        public void Add(IOrderItem item)
        {
            orderList.Add(item);
        }

        public void Remove(IOrderItem item)
        {
            orderList.Remove(item);
        }
    }
}
