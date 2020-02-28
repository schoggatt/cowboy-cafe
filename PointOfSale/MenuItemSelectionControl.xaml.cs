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
           
        }

        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                order.Add(new CowpokeChili());
            }
        }

        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs arg)
        {
            
        }

        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs arg)
        {
           
        }

        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs arg)
        {
            
        }

        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs arg)
        {
            
        }

        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs arg)
        {
            
        }

        //Side handlers adds new object to listbox on click

        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs arg)
        {
            
        }

        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs arg)
        {
           
        }

        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs arg)
        {
            
        }

        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs arg)
        {
            
        }

        //Drink handlers adds new object to listbox on click

        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs arg)
        {
            
        }

        private void AddWaterButton_Click(object sender, RoutedEventArgs arg)
        {
            
        }

        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs arg)
        {
            
        }

        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs arg)
        {
            
        }
    }
}
