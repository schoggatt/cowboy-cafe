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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
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
            AddCornDodgers.Click += AddPanDeCampoButton_Click;
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
            OrderList.Items.Add(new AngryChicken());
        }

        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs arg)
        {
            OrderList.Items.Add(new CowpokeChili());
        }

        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs arg)
        {
            OrderList.Items.Add(new PecosPulledPork());
        }

        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs arg)
        {
            OrderList.Items.Add(new TrailBurger());
        }

        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs arg)
        {
            OrderList.Items.Add(new DakotaDoubleBurger());
        }

        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs arg)
        {
            OrderList.Items.Add(new TexasTripleBurger());
        }

        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs arg)
        {
            OrderList.Items.Add(new RustlersRibs());
        }

        //Side handlers adds new object to listbox on click

        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs arg)
        {
            OrderList.Items.Add(new BakedBeans());
        }

        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs arg)
        {
            OrderList.Items.Add(new ChiliCheeseFries());
        }

        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs arg)
        {
            OrderList.Items.Add(new PanDeCampo());
        }

        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs arg)
        {
            OrderList.Items.Add(new CornDodgers());
        }

        //Drink handlers adds new object to listbox on click

        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs arg)
        {
            OrderList.Items.Add(new TexasTea());
        }

        private void AddWaterButton_Click(object sender, RoutedEventArgs arg)
        {
            OrderList.Items.Add(new Water());
        }

        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs arg)
        {
            OrderList.Items.Add(new CowboyCoffee());
        }

        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs arg)
        {
            OrderList.Items.Add(new JerkedSoda());
        }
    }
}

