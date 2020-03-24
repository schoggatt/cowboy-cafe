using CowboyCafe.Data;
using PointOfSale.Customizations;
using PointOfSale.ExtensionMethods;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
            MainBox.SelectionChanged += MainBox_SelectionChanged;
        }

        private void RemoveItem_Click(object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    if (button.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }

        private void MainBox_SelectionChanged(object sender, RoutedEventArgs arg)
        {
            if (DataContext is Order order)
            {
                if(sender is ListBox box)
                {
                    var orderControl = this.FindAncestor<OrderControl>();
                    if(box.SelectedItem is IOrderItem item)
                    {
                        FrameworkElement screen = null;

                        //Entrees

                        if(item is AngryChicken) screen = new AngryChickenCustomization();
                        if (item is CowpokeChili) screen = new CowpokeChiliCustomization();
                        if (item is PecosPulledPork) screen = new PecosPulledPorkCustomization();
                        if (item is RustlersRibs) screen = new RustlersRibsCustomization();
                        if (item is TrailBurger) screen = new TrailBurgerCustomization();
                        if (item is TexasTripleBurger) screen = new TexasTripleBurgerCustomization();
                        if (item is DakotaDoubleBurger) screen = new DakotaDoubleBurgerCustomization();

                        //Sides

                        if (item is PanDeCampo) screen = new PanDeCampoCustomization();
                        if (item is CornDodgers) screen = new CornDodgersCustomization();
                        if (item is BakedBeans) screen = new BakedBeansCustomization();
                        if (item is ChiliCheeseFries) screen = new ChiliCheeseFriesCustomization();

                        //Drinks

                        if (item is JerkedSoda) screen = new JerkedSodaCustomization();
                        if (item is CowboyCoffee) screen = new CowboyCoffeeCustomization();
                        if (item is Water) screen = new WaterCustomization();
                        if (item is TexasTea) screen = new TexasTeaCustomization();

                        screen.DataContext = item;
                        orderControl?.SwapScreen(screen);
                    }
                }
            }
        }
    }
}
