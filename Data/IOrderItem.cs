using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Interface for menu items
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Special instructions for a menu item
        /// </summary>
        List<string> SpecialInstructions { get; }
        /// <summary>
        /// Price for a menu item
        /// </summary>
        double Price { get; }

        uint Calories { get; }

        string DefaultString();
    }
}
