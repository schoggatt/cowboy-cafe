using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink
    {
        public abstract double Price { get; }

        public abstract uint Calories { get;  }

        public abstract List<string> Ingredients { get;  }

        public abstract Size Size { get;  }

        public bool Ice { get; set; } = true;

        


    }
}
