using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Base class for drinks
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        /// <summary>
        /// Price of a drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Calories in a drink
        /// </summary>
        public abstract uint Calories { get;  }

        /// <summary>
        /// Special instructions for a drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get;  }

        /// <summary>
        /// Size of a drink
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// If there is ice in the drink
        /// </summary>
        public virtual bool Ice { get; set; } = true;

    }
}
