using CashRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data.Transactions
{
    public class UserCashInputModelView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged; //Property changed handler

        static CashDrawer drawer = new CashDrawer(); //Static cash drawer shared among all instances

        private double totalValue = 0;
        /// <summary>
        /// Total value of this object
        /// </summary>
        public double TotalValue
        {
            get
            {
                return totalValue;
            }
            set
            {
                totalValue = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValueString"));
            }
        }

        /// <summary>
        /// If this is a customer input or employee input
        /// </summary>
        public bool isCustomerInput { get; set; } = true;

        /// <summary>
        /// Returns a string with the total value
        /// </summary>
        public string TotalValueString
        {
            get
            {
                if (isCustomerInput) return string.Format("Total Given: ${0:#0.00}", TotalValue);
                else if (TotalValue != 0) return string.Format("Total Given: ${0:#0.00}", TotalValue * -1);
                return string.Format("Total Given: ${0:#0.00}", TotalValue);
            }
        }

       

        //Bill properties that collect the quanity of each bill

        private int ones = 0;
        public int Ones
        {
            get
            {
                return ones;
            }
            set
            {
                ones = value;
            }
        }

        private int twos = 0;
        public int Twos
        {
            get
            {
                return twos;
            }
            set
            {
                twos = value;
            }
        }

        private int fives = 0;
        public int Fives
        {
            get
            {
                return fives;
            }
            set
            {
                fives = value;
            }
        }

        private int tens = 0;
        public int Tens
        {
            get
            {
                return tens;
            }
            set
            {
                tens = value;
            }
        }

        private int twenties = 0;
        public int Twenties
        {
            get
            {
                return twenties;
            }
            set
            {
                twenties = value;
            }
        }

        private int fifties = 0;
        public int Fifties
        {
            get
            {
                return fifties;
            }
            set
            {
                fifties = value;
            }
        }

        private int hundreds = 0;
        public int Hundreds
        {
            get
            {
                return hundreds;
            }
            set
            {
                hundreds = value;
            }
        }

        //Coin properties that collect the quanity of each coin

        private int pennies = 0;
        public int Pennies
        {
            get
            {
                return pennies;
            }
            set
            {
                pennies = value;
            }
        }

        private int nickels = 0;
        public int Nickels
        {
            get
            {
                return nickels;
            }
            set
            {
                nickels = value;
            }
        }

        private int dimes = 0;
        public int Dimes
        {
            get
            {
                return dimes;
            }
            set
            {
                dimes = value;
            }
        }

        private int quarters = 0;
        public int Quarters
        {
            get
            {
                return quarters;
            }
            set
            {
                quarters = value;
            }
        }

        private int halfDollars = 0;
        public int HalfDollars
        {
            get
            {
                return halfDollars;
            }
            set
            {
                halfDollars = value;
            }
        }

        private int dollars = 0;
        public int Dollars
        {
            get
            {
                return dollars;
            }
            set
            {
                dollars = value;
            }
        }

        /// <summary>
        /// Adds bills to the register and to the total
        /// </summary>
        /// <param name="bill"></param>
        public void AddBills(Bills bill)
        {
            if (bill is Bills.One)
            {
                drawer.AddBill(Bills.One, 1);
                TotalValue += 1;
                Ones++;
            }
            if (bill is Bills.Two)
            {
                drawer.AddBill(Bills.Two, 1);
                TotalValue += 2;
                Twos++;
            }
            if (bill is Bills.Five)
            {
                drawer.AddBill(Bills.Five, 1);
                TotalValue += 5;
                Fives++;
            }
            if (bill is Bills.Ten)
            {
                drawer.AddBill(Bills.Ten, 1);
                TotalValue += 10;
                Tens++;
            }
            if (bill is Bills.Twenty)
            {
                drawer.AddBill(Bills.Twenty, 1);
                TotalValue += 20;
                Twenties++;
            }
            if (bill is Bills.Fifty)
            {
                drawer.AddBill(Bills.Fifty, 1);
                TotalValue += 50;
                Fifties++;
            }
            if (bill is Bills.Hundred)
            {
                drawer.AddBill(Bills.Hundred, 1);
                TotalValue += 100;
                Hundreds++;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }

        /// <summary>
        /// Adds coins to the register and to the total
        /// </summary>
        /// <param name="coin"></param>
        public void AddCoins(Coins coin)
        {
            if (coin is Coins.Penny)
            {
                drawer.AddCoin(Coins.Penny, 1);
                TotalValue += .01;
                Pennies++;
            }
            if (coin is Coins.Nickel)
            {
                drawer.AddCoin(Coins.Nickel, 1);
                TotalValue += .05;
                Nickels++;
            }
            if (coin is Coins.Quarter)
            {
                drawer.AddCoin(Coins.Quarter, 1);
                TotalValue += .25;
                Quarters++;
            }
            if (coin is Coins.Dime)
            {
                drawer.AddCoin(Coins.Dime, 1);
                TotalValue += .1;
                Dimes++;
            }
            if (coin is Coins.HalfDollar)
            {
                drawer.AddCoin(Coins.HalfDollar, 1);
                TotalValue += .5;
                HalfDollars++;
            }
            if (coin is Coins.Dollar)
            {
                drawer.AddCoin(Coins.Dollar, 1);
                TotalValue += 1;
                Dollars++;
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }

        /// <summary>
        /// Removes bills from the register and from the total
        /// </summary>
        /// <param name="bill"></param>
        public void RemoveBills(Bills bill)
        {
            if (bill is Bills.One)
            {
                drawer.RemoveBill(Bills.One, 1);
                TotalValue -= 1;
                Ones--;

            }
            if (bill is Bills.Two)
            {

                drawer.RemoveBill(Bills.Two, 1);
                TotalValue -= 2;
                Twos--;

            }
            if (bill is Bills.Five)
            {

                drawer.RemoveBill(Bills.Five, 1);
                TotalValue -= 5;
                Fives--;

            }
            if (bill is Bills.Ten)
            {

                drawer.RemoveBill(Bills.Ten, 1);
                TotalValue -= 10;
                Tens--;

            }
            if (bill is Bills.Twenty)
            {

                drawer.RemoveBill(Bills.Twenty, 1);
                TotalValue -= 20;
                Twenties--;

            }
            if (bill is Bills.Fifty)
            {

                drawer.RemoveBill(Bills.Fifty, 1);
                TotalValue -= 50;
                Fifties--;

            }
            if (bill is Bills.Hundred)
            {

                drawer.RemoveBill(Bills.Hundred, 1);
                TotalValue -= 100;
                Hundreds--;

            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }

        /// <summary>
        /// Removes coins from the register and from the total
        /// </summary>
        /// <param name="coin"></param>
        public void RemoveCoins(Coins coin)
        {
            if (coin is Coins.Penny)
            {

                drawer.RemoveCoin(Coins.Penny, 1);
                TotalValue -= .01;
                Pennies--;

            }
            if (coin is Coins.Nickel)
            {

                drawer.RemoveCoin(Coins.Nickel, 1);
                TotalValue -= .05;
                Nickels--;

            }
            if (coin is Coins.Quarter)
            {

                drawer.RemoveCoin(Coins.Quarter, 1);
                TotalValue -= .25;
                Quarters++;

            }
            if (coin is Coins.Dime)
            {

                drawer.RemoveCoin(Coins.Dime, 1);
                TotalValue -= .1;
                Dimes--;

            }
            if (coin is Coins.HalfDollar)
            {

                drawer.RemoveCoin(Coins.HalfDollar, 1);
                TotalValue -= .5;
                HalfDollars--;

            }
            if (coin is Coins.Dollar)
            {

                drawer.RemoveCoin(Coins.Dollar, 1);
                TotalValue -= 1;
                Dollars--;

            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }
    }
}
