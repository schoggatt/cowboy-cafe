using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Tea class that inherits from the drink class
    /// </summary>
    public class TexasTea : Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Price of a tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException("NOT A SIZE");
                }
            }
        }

        /// <summary>
        /// Calories in a tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        uint caloriesS = 10;
                        if (!sweet) return caloriesS / 2;
                        return caloriesS;
                    case Size.Medium:
                        uint caloriesM = 22;
                        if (!sweet) return caloriesM / 2;
                        return caloriesM;
                    case Size.Large:
                        uint caloriesL = 36;
                        if (!sweet) return caloriesL / 2;
                        return caloriesL;
                    default:
                        throw new NotImplementedException("NOT A SIZE");
                }
            }
        }

        /// <summary>
        /// Special instructions for a tea
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }


        /// <summary>
        /// Whether there is a lemon in a tea
        /// </summary>
        private bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set { 
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Whether the tea is sweet or not
        /// </summary>
        private bool sweet = true;
        public bool Sweet 
        {
            get { return sweet; }
            set { 
                sweet = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sweet"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Ice in a tea
        /// </summary>
        private bool ice = true;

        public override bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private Size size = Size.Small;

        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    if (Sweet) return "Small Texas Sweet Tea";
                    return "Small Texas Plain Tea";
                case Size.Medium:
                    if (Sweet) return "Medium Texas Sweet Tea";
                    return "Medium Texas Plain Tea";
                case Size.Large:
                    if (Sweet) return "Large Texas Sweet Tea";
                    return "Large Texas Plain Tea";
                default:
                    throw new NotImplementedException("NOT A SIZE");
            }
        }

        /// <summary>
        /// Returns a default ToString with no size
        /// </summary>
        /// <returns></returns>
        public override string DefaultString()
        {
            return "Texas Tea";
        }
    }
}
