using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Coffee class that inherits from the drink class
    /// </summary>
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// The price of a coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException("NOT A SIZE");
                }
            }
        }

        /// <summary>
        /// The amount of calories in a coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException("NOT A SIZE");
                }
            }
        }

        /// <summary>
        /// Special instructions for a coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");

                return instructions;
            }
        }

        /// <summary>
        /// Whether coffee needs cream or not
        /// </summary>
        private bool roomForCream = false;
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }

        /// <summary>
        /// Whether coffee is decaf
        /// </summary>
        private bool decaf = false;
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        /// <summary>
        /// Default ice to false
        /// </summary>
        public override bool Ice { get; set; } = false;

        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    if (Decaf) return "Small Decaf Cowboy Coffee";
                    return "Small Cowboy Coffee";
                case Size.Medium:
                    if (Decaf) return "Medium Decaf Cowboy Coffee";
                    return "Medium Cowboy Coffee";
                case Size.Large:
                    if (Decaf) return "Large Decaf Cowboy Coffee";
                    return "Large Cowboy Coffee";
                default:
                    throw new NotImplementedException("NOT A SIZE");
            }
        }
    }
}
