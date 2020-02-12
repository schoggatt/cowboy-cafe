using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException("NOT A SIZE");
                }
            }
        }

        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        uint caloriesS = 10;
                        if (!sweet) return caloriesS / 2;
                        return caloriesS;
                    case Size.Medium:
                        uint caloriesM = 22;
                        if (!sweet) return caloriesM / 2;
                        return caloriesM;
                    case Size.Large:
                        uint caloriesL = 36;
                        if (!sweet) return caloriesL / 2;
                        return caloriesL;
                    default:
                        throw new NotImplementedException("NOT A SIZE");
                }
            }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");

                return instructions;
            }
        }

        private bool lemon = false;
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        private bool sweet = true;
        public bool Sweet 
        {
            get { return sweet; }
            set { sweet = value; }
        }
    }
}
