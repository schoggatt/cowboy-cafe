using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Entree : IOrderItem
    {

        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get; }
        
        /// <summary>
        /// Gets the calories in the entree
        /// </summary>
        public abstract uint Calories { get; }
        
        /// <summary>
        /// Gets the special instructions for the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Default string for the object
        /// </summary>
        /// <returns></returns>
        public virtual string DefaultString()
        {
            return ToString();
        }
    }
}
