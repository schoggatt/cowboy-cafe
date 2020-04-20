using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Base class for drinks
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Price of a drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Calories in a drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for a drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Size of a drink
        /// </summary>

        public abstract Size Size{ get; set; }

        /// <summary>
        /// If there is ice in the drink
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// Returns a default ToString with no size
        /// </summary>
        /// <returns></returns>
        public abstract string DefaultString();
    }
}
