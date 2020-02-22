﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Pan de Campo class that inherits from side class
    /// </summary>
    public class PanDeCampo : Side
    {
        /// <summary>
        /// Price of pan de campo
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
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException("NOT A SIZE");
                }
            }
        }

        /// <summary>
        /// Calories for pan de campo
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
                    default:
                        throw new NotImplementedException("NOT A SIZE");
                }
            }
        }

        /// <summary>
        /// Converts object to string when called
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Small:
                    return "Small Pan de Campo";
                case Size.Medium:
                    return "Medium Pan de Campo";
                case Size.Large:
                    return "Large Pan de Campo";
                default:
                    throw new NotImplementedException("NOT A SIZE");
            }
        }
    }
}
