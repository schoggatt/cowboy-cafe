using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using PointOfSale.Customizations;
using PointOfSale.ExtensionMethods;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();

            //Entrees handlers

            AddAngryChicken.Click += AddAngryChickenButton_Click;
            AddCowpokeChili.Click += AddCowpokeChiliButton_Click;
            AddTrailBurger.Click += AddTrailBurgerButton_Click;
            AddDakotaDoubleBurger.Click += AddDakotaDoubleBurgerButton_Click;
            AddTexasTripleBurger.Click += AddTexasTripleBurgerButton_Click;
            AddPecosPulledPork.Click += AddPecosPulledPorkButton_Click;
            AddRustlerRibs.Click += AddRustlersRibsButton_Click;

            //Sides handlers

            AddBakedBeans.Click += AddBakedBeansButton_Click;
            AddPanDeCampo.Click += AddPanDeCampoButton_Click;
            AddCornDodgers.Click += AddCornDodgersButton_Click;
            AddChiliCheeseFries.Click += AddChiliCheeseFriesButton_Click;

            //Drink handlers

            AddJerkedSoda.Click += AddJerkedSodaButton_Click;
            AddWater.Click += AddWaterButton_Click;
            AddCowboyCoffee.Click += AddCowboyCoffeeButton_Click;
            AddTexasTea.Click += AddTexasTeaButton_Click;
        }

        //Entree handlers adds new object to listbox on click

        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs arg)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new AngryChickenCustomization();
            if (DataContext is Order order)
            {
                var item = new AngryChicken();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs arg)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new CowpokeChiliCustomization();
            if (DataContext is Order order)
            {
                var item = new CowpokeChili();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs arg)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new PecosPulledPorkCustomization();
            if (DataContext is Order order)
            {
                var item = new PecosPulledPork();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs arg)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new TrailBurgerCustomization();
            if (DataContext is Order order)
            {
                var item = new TrailBurger();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs arg)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new DakotaDoubleBurgerCustomization();
            if (DataContext is Order order)
            {
                var item = new DakotaDoubleBurger();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs arg)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new TexasTripleBurgerCustomization();
            if (DataContext is Order order)
            {
                var item = new TexasTripleBurger();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs arg)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new RustlersRibsCustomization();
            if (DataContext is Order order)
            {
                var item = new RustlersRibs();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        //Side handlers adds new object to listbox on click

        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs arg)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new BakedBeansCustomization();
            if (DataContext is Order order)
            {
                var item = new BakedBeans();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs arg)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new ChiliCheeseFriesCustomization();
            if (DataContext is Order order)
            {
                var item = new ChiliCheeseFries();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs arg)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new PanDeCampoCustomization();
            if (DataContext is Order order)
            {
                var item = new PanDeCampo();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs arg)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new CornDodgersCustomization();
            if (DataContext is Order order)
            {
                var item = new CornDodgers();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        //Drink handlers adds new object to listbox on click

        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs arg)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new TexasTeaCustomization();
            if (DataContext is Order order)
            {
                var item = new TexasTea();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddWaterButton_Click(object sender, RoutedEventArgs arg)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new WaterCustomization();
            if (DataContext is Order order)
            {
                var item = new Water();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs arg)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new CowboyCoffeeCustomization();
            if (DataContext is Order order)
            {
                var item = new CowboyCoffee();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }

        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs arg)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            var screen = new JerkedSodaCustomization();
            if (DataContext is Order order)
            {
                var item = new JerkedSoda();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);
            }
        }
    }
}
