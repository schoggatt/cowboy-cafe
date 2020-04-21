using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CowboyCafe.Data;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    public class MenuTests
    {

        [Fact]
        public void ShouldReturnAllItems()
        {
            var items = Menu.All;
            var result = Menu.All;

            bool val = result.Contains(new CowboyCoffee());
            Assert.True(val);
        }

        [Theory]
        [InlineData("Entree")]
        public void ShouldReturnAllOfType(string type)
        {
            var list = new List<IOrderItem>();
            switch(type)
            {
                case "Entree":
                    list = (List<IOrderItem>)Menu.Entrees();
                    break;
                case "Side":
                    list = (List<IOrderItem>)Menu.Sides();
                    break;
                case "Drink":
                    list = (List<IOrderItem>)Menu.Drinks();
                    break;
            }
            foreach(IOrderItem item in list)
            {
                if (!(item is Entree))
                {
                    Assert.False(false);
                }
            }
            Assert.True(true);
        }

        [Fact]
        public void ShouldReturnAllSides()
        {
            var items = Menu.Sides();
            var result = new List<IOrderItem>();

            CornDodgers dodgersS = new CornDodgers();
            dodgersS.Size = Size.Small;
            result.Add(dodgersS);
            CornDodgers dodgersM = new CornDodgers();
            dodgersM.Size = Size.Medium;
            result.Add(dodgersM);
            CornDodgers dodgersL = new CornDodgers();
            dodgersL.Size = Size.Large;
            result.Add(dodgersL);

            ChiliCheeseFries chiliS = new ChiliCheeseFries();
            chiliS.Size = Size.Small;
            result.Add(chiliS);
            ChiliCheeseFries chiliM = new ChiliCheeseFries();
            chiliM.Size = Size.Medium;
            result.Add(chiliM);
            ChiliCheeseFries chiliL = new ChiliCheeseFries();
            chiliL.Size = Size.Large;
            result.Add(chiliL);

            BakedBeans bakedS = new BakedBeans();
            bakedS.Size = Size.Small;
            result.Add(bakedS);
            BakedBeans bakedM = new BakedBeans();
            bakedM.Size = Size.Medium;
            result.Add(bakedM);
            BakedBeans bakedL = new BakedBeans();
            bakedL.Size = Size.Large;
            result.Add(bakedL);

            PanDeCampo campoS = new PanDeCampo();
            campoS.Size = Size.Small;
            result.Add(campoS);
            PanDeCampo campoM = new PanDeCampo();
            campoM.Size = Size.Medium;
            result.Add(campoM);
            PanDeCampo campoL = new PanDeCampo();
            campoL.Size = Size.Large;
            result.Add(campoL);

            Assert.True(items.SequenceEqual(result));
        }

        [Fact]
        public void ShouldReturnAllDrinks()
        {
            var items = Menu.Drinks();
            var result = new List<IOrderItem>();
            

            Assert.True(items.SequenceEqual(result));
        }

        [Theory]
        [InlineData(750, 1000, 1)]
        [InlineData(null, 0, 4)]
        [InlineData(700, null, 2)]
        [InlineData(null, null, 34)]

        public void ShouldFilterByCalories(double? min, double? max, int expected)
        {
            var items = Menu.CompleteMenu();
            var result = Menu.FilterByCalories(items, min, max);

            if (result is List<IOrderItem> method)
            {
                Assert.Equal(expected, method.Count);
            }
        }

        [Theory]
        [InlineData(4, 5, 1)]
        [InlineData(null, .5, 4)]
        [InlineData(5, null, 6)]
        [InlineData(null, null, 34)]

        public void ShouldFilterByPrice(double? min, double? max, int expected)
        {
            var items = Menu.CompleteMenu();
            var result = Menu.FilterByPrice(items, min, max);

            if (result is List<IOrderItem> method)
            {
                Assert.Equal(expected, method.Count);
            }
        }

        [Theory]
        [InlineData("Pecos", 1)]
        [InlineData(null, 34)]
        [InlineData("", 34)]
        [InlineData("Chi", 5)]

        public void ShouldFilterByTerm(string term, int expected)
        {
            var items = Menu.CompleteMenu();
            var result = Menu.Search(term);

            if (result is List<IOrderItem> method)
            {
                Assert.Equal(expected, method.Count);
            }
        }

        [Theory]
        [InlineData(new string[] {"Entree"} , 7)]
        [InlineData(null, 34)]
        [InlineData(new string[] {}, 34)]
        [InlineData(new string[] { "Side", "Entree" }, 19)]

        public void ShouldFilterByType(string[] types, int expected)
        {
            var items = Menu.CompleteMenu();
            var result = Menu.FilterByType(items, types);

            if (result is List<IOrderItem> method)
            {
                Assert.Equal(expected, method.Count);
            }
        }
    }
}
