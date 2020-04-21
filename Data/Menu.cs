using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Static menu class to return lists of available items
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Returns a list of all items
        /// </summary>
        public static IEnumerable<IOrderItem> All
        {
            get
            {
                return Menu.CompleteMenu();
            }
        }

        /// <summary>
        /// Returns a list of all the entrees
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> menuList = new List<IOrderItem>();
            menuList.Add(new CowpokeChili());
            menuList.Add(new AngryChicken());
            menuList.Add(new PecosPulledPork());
            menuList.Add(new TrailBurger());
            menuList.Add(new TexasTripleBurger());
            menuList.Add(new DakotaDoubleBurger());
            menuList.Add(new RustlersRibs());

            return menuList;
        }

        /// <summary>
        /// Returns a list of all the sides
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> menuList = new List<IOrderItem>();

            //Sides

            CornDodgers dodgersS = new CornDodgers();
            dodgersS.Size = Size.Small;
            menuList.Add(dodgersS);
            CornDodgers dodgersM = new CornDodgers();
            dodgersM.Size = Size.Medium;
            menuList.Add(dodgersM);
            CornDodgers dodgersL = new CornDodgers();
            dodgersL.Size = Size.Large;
            menuList.Add(dodgersL);

            ChiliCheeseFries chiliS = new ChiliCheeseFries();
            chiliS.Size = Size.Small;
            menuList.Add(chiliS);
            ChiliCheeseFries chiliM = new ChiliCheeseFries();
            chiliM.Size = Size.Medium;
            menuList.Add(chiliM);
            ChiliCheeseFries chiliL = new ChiliCheeseFries();
            chiliL.Size = Size.Large;
            menuList.Add(chiliL);

            BakedBeans bakedS = new BakedBeans();
            bakedS.Size = Size.Small;
            menuList.Add(bakedS);
            BakedBeans bakedM = new BakedBeans();
            bakedM.Size = Size.Medium;
            menuList.Add(bakedM);
            BakedBeans bakedL = new BakedBeans();
            bakedL.Size = Size.Large;
            menuList.Add(bakedL);

            PanDeCampo campoS = new PanDeCampo();
            campoS.Size = Size.Small;
            menuList.Add(campoS);
            PanDeCampo campoM = new PanDeCampo();
            campoM.Size = Size.Medium;
            menuList.Add(campoM);
            PanDeCampo campoL = new PanDeCampo();
            campoL.Size = Size.Large;
            menuList.Add(campoL);

            return menuList;
        }

        /// <summary>
        /// Returns a list of all the drinks
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> menuList = new List<IOrderItem>();

            //Drinks

            JerkedSoda sodaS = new JerkedSoda();
            sodaS.Size = Size.Small;
            menuList.Add(sodaS);
            JerkedSoda sodaM = new JerkedSoda();
            sodaM.Size = Size.Medium;
            menuList.Add(sodaM);
            JerkedSoda sodaL = new JerkedSoda();
            sodaL.Size = Size.Large;
            menuList.Add(sodaL);

            Water waterS = new Water();
            waterS.Size = Size.Small;
            menuList.Add(waterS);
            Water waterM = new Water();
            waterM.Size = Size.Medium;
            menuList.Add(waterM);
            Water waterL = new Water();
            waterL.Size = Size.Large;
            menuList.Add(waterL);

            CowboyCoffee coffeeS = new CowboyCoffee();
            coffeeS.Size = Size.Small;
            menuList.Add(coffeeS);
            CowboyCoffee coffeeM = new CowboyCoffee();
            coffeeM.Size = Size.Medium;
            menuList.Add(coffeeM);
            CowboyCoffee coffeeL = new CowboyCoffee();
            coffeeL.Size = Size.Large;
            menuList.Add(coffeeL);

            TexasTea teaS = new TexasTea();
            teaS.Size = Size.Small;
            menuList.Add(teaS);
            TexasTea teaM = new TexasTea();
            teaM.Size = Size.Medium;
            menuList.Add(teaM);
            TexasTea teaL = new TexasTea();
            teaL.Size = Size.Large;
            menuList.Add(teaL);

            TexasTea teaSUS = new TexasTea();
            teaSUS.Size = Size.Small;
            teaSUS.Sweet = false;
            menuList.Add(teaSUS);
            TexasTea teaMUS = new TexasTea();
            teaMUS.Size = Size.Medium;
            teaMUS.Sweet = false;
            menuList.Add(teaMUS);
            TexasTea teaLUS = new TexasTea();
            teaLUS.Size = Size.Large;
            teaLUS.Sweet = false;
            menuList.Add(teaLUS);

            return menuList;
        }

        /// <summary>
        /// Returns a list of all the items on the menu
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            //Entrees

            List<IOrderItem> menuList = new List<IOrderItem>();
            menuList.Add(new CowpokeChili());
            menuList.Add(new AngryChicken());
            menuList.Add(new PecosPulledPork());
            menuList.Add(new TrailBurger());
            menuList.Add(new TexasTripleBurger());
            menuList.Add(new DakotaDoubleBurger());
            menuList.Add(new RustlersRibs());

            //Sides

            CornDodgers dodgersS = new CornDodgers();
            dodgersS.Size = Size.Small;
            menuList.Add(dodgersS);
            CornDodgers dodgersM = new CornDodgers();
            dodgersM.Size = Size.Medium;
            menuList.Add(dodgersM);
            CornDodgers dodgersL = new CornDodgers();
            dodgersL.Size = Size.Large;
            menuList.Add(dodgersL);

            ChiliCheeseFries chiliS = new ChiliCheeseFries();
            chiliS.Size = Size.Small;
            menuList.Add(chiliS);
            ChiliCheeseFries chiliM = new ChiliCheeseFries();
            chiliM.Size = Size.Medium;
            menuList.Add(chiliM);
            ChiliCheeseFries chiliL = new ChiliCheeseFries();
            chiliL.Size = Size.Large;
            menuList.Add(chiliL);

            BakedBeans bakedS = new BakedBeans();
            bakedS.Size = Size.Small;
            menuList.Add(bakedS);
            BakedBeans bakedM = new BakedBeans();
            bakedM.Size = Size.Medium;
            menuList.Add(bakedM);
            BakedBeans bakedL = new BakedBeans();
            bakedL.Size = Size.Large;
            menuList.Add(bakedL);

            PanDeCampo campoS = new PanDeCampo();
            campoS.Size = Size.Small;
            menuList.Add(campoS);
            PanDeCampo campoM = new PanDeCampo();
            campoM.Size = Size.Medium;
            menuList.Add(campoM);
            PanDeCampo campoL = new PanDeCampo();
            campoL.Size = Size.Large;
            menuList.Add(campoL);

            //Drinks

            JerkedSoda sodaS = new JerkedSoda();
            sodaS.Size = Size.Small;
            menuList.Add(sodaS);
            JerkedSoda sodaM = new JerkedSoda();
            sodaM.Size = Size.Medium;
            menuList.Add(sodaM);
            JerkedSoda sodaL = new JerkedSoda();
            sodaL.Size = Size.Large;
            menuList.Add(sodaL);

            Water waterS = new Water();
            waterS.Size = Size.Small;
            menuList.Add(waterS);
            Water waterM = new Water();
            waterM.Size = Size.Medium;
            menuList.Add(waterM);
            Water waterL = new Water();
            waterL.Size = Size.Large;
            menuList.Add(waterL);

            CowboyCoffee coffeeS = new CowboyCoffee();
            coffeeS.Size = Size.Small;
            menuList.Add(coffeeS);
            CowboyCoffee coffeeM = new CowboyCoffee();
            coffeeM.Size = Size.Medium;
            menuList.Add(coffeeM);
            CowboyCoffee coffeeL = new CowboyCoffee();
            coffeeL.Size = Size.Large;
            menuList.Add(coffeeL);

            TexasTea teaS = new TexasTea();
            teaS.Size = Size.Small;
            menuList.Add(teaS);
            TexasTea teaM = new TexasTea();
            teaM.Size = Size.Medium;
            menuList.Add(waterM);
            TexasTea teaL = new TexasTea();
            teaL.Size = Size.Large;
            menuList.Add(teaL);

            TexasTea teaSUS = new TexasTea();
            teaSUS.Size = Size.Small;
            teaSUS.Sweet = false;
            menuList.Add(teaSUS);
            TexasTea teaMUS = new TexasTea();
            teaMUS.Size = Size.Medium;
            teaMUS.Sweet = false;
            menuList.Add(teaMUS);
            TexasTea teaLUS = new TexasTea();
            teaLUS.Size = Size.Large;
            teaLUS.Sweet = false;
            menuList.Add(teaLUS);

            return menuList;
        }

        /// <summary>
        /// Searches through the list for the given terms
        /// </summary>
        /// <param name="terms"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (terms == null) return Menu.CompleteMenu();
            foreach (IOrderItem item in Menu.CompleteMenu())
            {
                if (item.ToString() != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the given list by a type i.e Side, Drink, Entree
        /// </summary>
        /// <param name="items"></param>
        /// <param name="types"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByType(IEnumerable<IOrderItem> items, string[] types)
        {
            if (types == null || types.Length == 0) return items;
            List<IOrderItem> result = new List<IOrderItem>();
            foreach (string type in types)
            {
                switch (type)
                {
                    case "Entree":
                        foreach (IOrderItem item in items)
                        {
                            if(item is Entree) result.Add(item);
                        }
                        break;
                    case "Side":
                        foreach (IOrderItem item in items)
                        {
                            if (item is Side) result.Add(item);
                        }
                        break;
                    case "Drink":
                        foreach (IOrderItem item in items)
                        {
                            if (item is Drink) result.Add(item);
                        }
                        break;
                    default:
                        return items;
                }
            }
            return result;
        }

        /// <summary>
        /// Filters by a minimum and maximum calorie mount
        /// </summary>
        /// <param name="items"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Sorts by a minimum or maximum price
        /// </summary>
        /// <param name="items"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
