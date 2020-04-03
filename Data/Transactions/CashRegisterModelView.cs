using CashRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data.Transactions
{
    public class CashRegisterModelView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        CashDrawer drawer = new CashDrawer();

        /// <summary>
        /// The total current value of the drawer
        /// </summary>
        public double TotalValue
        {
            get
            {
                return drawer.TotalValue;
            }
        }

        /// <summary>
        /// Invokes the PropertyChanged event for denomination properties
        /// and the TotalValue
        /// </summary>
        /// <param name="denomination">The property that is changing</param>
        private void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }

        //Coin Properties

        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Pennies
        {
            get => drawer.Pennies;

            set
            {
                if (drawer.Pennies == value || value < 0) return;
                int quantity = value - drawer.Pennies;
                if (quantity > 0) drawer.AddCoin(Coins.Penny, quantity);
                else drawer.RemoveCoin(Coins.Penny, -quantity);
                InvokePropertyChanged("Pennies");
            }
        }

        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Nickels
        {
            get => drawer.Nickels;

            set
            {
                if (drawer.Nickels == value || value < 0) return;
                int quantity = value - drawer.Nickels;
                if (quantity > 0) drawer.AddCoin(Coins.Nickel, quantity);
                else drawer.RemoveCoin(Coins.Nickel, -quantity);
                InvokePropertyChanged("Nickels");
            }
        }

        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Quarters
        {
            get => drawer.Quarters;

            set
            {
                if (drawer.Quarters == value || value < 0) return;
                int quantity = value - drawer.Quarters;
                if (quantity > 0) drawer.AddCoin(Coins.Quarter, quantity);
                else drawer.RemoveCoin(Coins.Quarter, -quantity);
                InvokePropertyChanged("Quarters");
            }
        }

        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Dimes
        {
            get => drawer.Dimes;

            set
            {
                if (drawer.Dimes == value || value < 0) return;
                int quantity = value - drawer.Dimes;
                if (quantity > 0) drawer.AddCoin(Coins.Dime, quantity);
                else drawer.RemoveCoin(Coins.Dime, -quantity);
                InvokePropertyChanged("Dimes");
            }
        }

        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int HalfDollar
        {
            get => drawer.HalfDollars;

            set
            {
                if (drawer.HalfDollars == value || value < 0) return;
                int quantity = value - drawer.HalfDollars;
                if (quantity > 0) drawer.AddCoin(Coins.HalfDollar, quantity);
                else drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                InvokePropertyChanged("HalfDollar");
            }
        }

        /// <summary>
        /// Gets or sets the number of pennies in the cash register
        /// </summary>
        public int Dollar
        {
            get => drawer.Dollars;

            set
            {
                if (drawer.Dollars == value || value < 0) return;
                int quantity = value - drawer.Dollars;
                if (quantity > 0) drawer.AddCoin(Coins.Dollar, quantity);
                else drawer.RemoveCoin(Coins.Dollar, -quantity);
                InvokePropertyChanged("Dollar");
            }
        }

        //Bills Properties

        public int Ones
        {
            get => drawer.Ones;

            set
            {
                if (drawer.Ones == value || value < 0) return;
                int quantity = value - drawer.Ones;
                if (quantity > 0) drawer.AddBill(Bills.One, quantity);
                else drawer.RemoveBill(Bills.One, -quantity);
                InvokePropertyChanged("Ones");
            }
        }

        public int Twos
        {
            get => drawer.Twos;

            set
            {
                if (drawer.Twos == value || value < 0) return;
                int quantity = value - drawer.Twos;
                if (quantity > 0) drawer.AddBill(Bills.Two, quantity);
                else drawer.RemoveBill(Bills.Two, -quantity);
                InvokePropertyChanged("Twos");
            }
        }

        public int Fives
        {
            get => drawer.Fives;

            set
            {
                if (drawer.Fives == value || value < 0) return;
                int quantity = value - drawer.Fives;
                if (quantity > 0) drawer.AddBill(Bills.Five, quantity);
                else drawer.RemoveBill(Bills.Five, -quantity);
                InvokePropertyChanged("Fives");
            }
        }

        public int Tens
        {
            get => drawer.Tens;

            set
            {
                if (drawer.Tens == value || value < 0) return;
                int quantity = value - drawer.Tens;
                if (quantity > 0) drawer.AddBill(Bills.Ten, quantity);
                else drawer.RemoveBill(Bills.Ten, -quantity);
                InvokePropertyChanged("Tens");
            }
        }

        public int Twenty
        {
            get => drawer.Twenties;

            set
            {
                if (drawer.Twenties == value || value < 0) return;
                int quantity = value - drawer.Twenties;
                if (quantity > 0) drawer.AddBill(Bills.Twenty, quantity);
                else drawer.RemoveBill(Bills.Twenty, -quantity);
                InvokePropertyChanged("Twenty");
            }
        }

        public int Fifty
        {
            get => drawer.Fifties;

            set
            {
                if (drawer.Fifties == value || value < 0) return;
                int quantity = value - drawer.Fifties;
                if (quantity > 0) drawer.AddBill(Bills.Fifty, quantity);
                else drawer.RemoveBill(Bills.Fifty, -quantity);
                InvokePropertyChanged("Fifty");
            }
        }

        public int Hundred
        {
            get => drawer.Hundreds;

            set
            {
                if (drawer.Hundreds == value || value < 0) return;
                int quantity = value - drawer.Hundreds;
                if (quantity > 0) drawer.AddBill(Bills.Hundred, quantity);
                else drawer.RemoveBill(Bills.Hundred, -quantity);
                InvokePropertyChanged("Hundred");
            }
        }
    }
}
