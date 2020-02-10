using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        public override double Price => throw new NotImplementedException();

        public override uint Calories => throw new NotImplementedException();

        public override List<string> Ingredients => throw new NotImplementedException();

        public override Size Size => throw new NotImplementedException();
    }
}
