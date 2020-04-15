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

            menuList.Add(new JerkedSoda());
            menuList.Add(new Water());
            menuList.Add(new CowboyCoffee());
            menuList.Add(new TexasTea());

            menuList.Add(new CornDodgers());
            menuList.Add(new ChiliCheeseFries());
            menuList.Add(new BakedBeans());
            menuList.Add(new PanDeCampo());

            return menuList;
        }
    }
}
