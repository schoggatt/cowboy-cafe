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
            AddAngryChicken.Click += AddAngryChickenButton_Click;
            AddBakedBeans.Click += AddBakedBeansButton_Click;
            AddCowpokeChili.Click += AddCowpokeChiliButton_Click;
        }

        //Entree Handlers

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

        //Side Handlers

        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs arg)
        {
            OrderList.Items.Add(new BakedBeans());
        }

        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs arg)
        {
            OrderList.Items.Add(new ChiliCheeseFries());
        }

        private void AddChiliPanDeCampoButton_Click(object sender, RoutedEventArgs arg)
        {
            OrderList.Items.Add(new PanDeCampo());
        }

        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs arg)
        {
            OrderList.Items.Add(new CornDodgers());
        }

        //Drinks

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

