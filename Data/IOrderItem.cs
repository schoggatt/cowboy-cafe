using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {
        List<string> SpecialInstructions { get; }
        double Price { get; }
    }
}
