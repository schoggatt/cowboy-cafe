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

            menuList.Add(new CornDodgers());
            menuList.Add(new ChiliCheeseFries());
            menuList.Add(new BakedBeans());
            menuList.Add(new PanDeCampo());

            return menuList;
        }

        /// <summary>
        /// Returns a list of all the drinks
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> menuList = new List<IOrderItem>();

            menuList.Add(new JerkedSoda());
            menuList.Add(new Water());
            menuList.Add(new CowboyCoffee());
            menuList.Add(new TexasTea());

            return menuList;
        }

        /// <summary>
        /// Returns a list of all the items on the menu
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> menuList = new List<IOrderItem>();
            menuList.Add(new CowpokeChili());
            menuList.Add(new AngryChicken());
            menuList.Add(new PecosPulledPork());
            menuList.Add(new TrailBurger());
            menuList.Add(new TexasTripleBurger());
            menuList.Add(new DakotaDoubleBurger());
            menuList.Add(new RustlersRibs());

            CornDodgers dodgers = new CornDodgers();
            dodgers.Size = Size.Small;
            menuList.Add(dodgers);
            dodgers.Size = Size.Medium;
            menuList.Add(dodgers);
            dodgers.Size = Size.Large;
            menuList.Add(dodgers);

            ChiliCheeseFries chili = new ChiliCheeseFries();
            chili.Size = Size.Small;
            menuList.Add(chili);
            chili.Size = Size.Medium;
            menuList.Add(chili);
            chili.Size = Size.Large;
            menuList.Add(chili);

            /*menuList.Add(new CornDodgers());
            menuList.Add(new ChiliCheeseFries());
            menuList.Add(new BakedBeans());
            menuList.Add(new PanDeCampo());

            menuList.Add(new JerkedSoda());
            menuList.Add(new Water());
            menuList.Add(new CowboyCoffee());
            menuList.Add(new TexasTea());*/

            return menuList;
        }

        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            // Return all movies if there are no search terms
            if (terms == null) return Menu.CompleteMenu();
            // return each movie in the database containing the terms substring
            foreach (IOrderItem item in Menu.CompleteMenu())
            {
                if (item.ToString() != null && item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByType(IEnumerable<IOrderItem> items, string type)
        {
            // If no filter is specified, just return the provided collection
            if (type == null || type == "") return items;
            // Filter the supplied collection of movies
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in items)
            {
                
            }
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            // only a minimum specified 
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            // Both minimum and maximum specified
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
