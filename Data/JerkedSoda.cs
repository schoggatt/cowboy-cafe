﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Soda class that inherits from the drink class
    /// </summary>
    public class JerkedSoda : Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Price of a soda
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException("NOT A SIZE");
                }
            }
        }

        /// <summary>
        /// Calories in a soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException("NOT A SIZE");
                }
            }
        }

        /// <summary>
        /// Special instructions for a soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");

                return instructions;
            }
        }

        /// <summary>
        /// Flavor for a soda
        /// </summary>
        SodaFlavor flavor = SodaFlavor.CreamSoda; 

        public SodaFlavor Flavor
        {
            get { return flavor; }
            set
            {
                flavor = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Default ice to false
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

        /// <summary>
        /// Size of soda
        /// </summary>
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

        /// <summary>
        /// Converts object to string when called
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string flavor;

            switch (Flavor)
            {
                case SodaFlavor.CreamSoda:
                    flavor = "Cream Soda";
                    break;
                case SodaFlavor.BirchBeer:
                    flavor = "Birch Beer";
                    break;
                case SodaFlavor.OrangeSoda:
                    flavor = "Orange Soda";
                    break;
                case SodaFlavor.RootBeer:
                    flavor = "Root Beer";
                    break;
                case SodaFlavor.Sarsparilla:
                    flavor = "Sarsparilla";
                    break; 
                default:
                    flavor = "";
                    break;
            }

            switch (Size)
            {
                case Size.Small:
                    return "Small " + flavor + " Jerked Soda";
                case Size.Medium:
                    return "Medium " + flavor + " Jerked Soda";
                case Size.Large:
                    return "Large " + flavor + " Jerked Soda";
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
            return "Jerked Soda";
        }
    }
}
