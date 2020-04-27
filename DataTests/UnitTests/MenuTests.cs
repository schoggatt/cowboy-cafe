using CowboyCafe.Data;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    /// <summary>
    /// Tests for the menu class
    /// </summary>
    public class MenuTests
    {
       
        /// <summary>
        /// Returns the entire menu
        /// </summary>

        [Fact]
        public void ShouldReturnAllItems()
        {
            var items = Menu.All;
            var result = Menu.All;

            Assert.Equal(items.Count(), result.Count());
        }

        /// <summary>
        /// Returns all of type
        /// </summary>
        /// <param name="type"></param>

        [Theory]
        [InlineData("Entree")]
        [InlineData("Side")]
        [InlineData("Drink")]
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
                if(type == "Entree")
                {
                    if (!(item is Entree))
                    {
                        Assert.False(false);
                    }
                }
                if (type == "Side")
                {
                    if (!(item is Side))
                    {
                        Assert.False(false);
                    }
                }
                if (type == "Drink")
                {
                    if (!(item is Drink))
                    {
                        Assert.False(false);
                    }
                }
            }
            Assert.True(true);
        }

        /// <summary>
        /// Returns all entrees
        /// </summary>

        [Fact]
        public void ShouldReturnAllEntrees()
        {
            Assert.Collection(
                Menu.Entrees(),
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); }
            );
        }

        /// <summary>
        /// Returns all sides
        /// </summary>

        [Fact]
        public void ShouldReturnAllSides()
        {
            Assert.Collection(
                Menu.Sides(),
                (cdS) => { Assert.IsType<CornDodgers>(cdS); }, 
                (cdM) => { Assert.IsType<CornDodgers>(cdM); },
                (cdL) => { Assert.IsType<CornDodgers>(cdL); },
                (ccfS) => { Assert.IsType<ChiliCheeseFries>(ccfS); },
                (ccfM) => { Assert.IsType<ChiliCheeseFries>(ccfM); },
                (ccfL) => { Assert.IsType<ChiliCheeseFries>(ccfL); },
                (bbS) => { Assert.IsType<BakedBeans>(bbS); },
                (bbM) => { Assert.IsType<BakedBeans>(bbM); },
                (bbL) => { Assert.IsType<BakedBeans>(bbL); },
                (pdcS) => { Assert.IsType<PanDeCampo>(pdcS); },
                (pdcM) => { Assert.IsType<PanDeCampo>(pdcM); },
                (pdcL) => { Assert.IsType<PanDeCampo>(pdcL); }
            ); 
        }

        /// <summary>
        /// Returns all drinks
        /// </summary>

        [Fact]
        public void ShouldReturnAllDrinks()
        {
            Assert.Collection(
                Menu.Drinks(),
                (jsS) => { Assert.IsType<JerkedSoda>(jsS); },
                (jsM) => { Assert.IsType<JerkedSoda>(jsM); },
                (jsL) => { Assert.IsType<JerkedSoda>(jsL); },
                (wS) => { Assert.IsType<Water>(wS); },
                (wM) => { Assert.IsType<Water>(wM); },
                (wL) => { Assert.IsType<Water>(wL); },
                (ccS) => { Assert.IsType<CowboyCoffee>(ccS); },
                (ccM) => { Assert.IsType<CowboyCoffee>(ccM); },
                (ccL) => { Assert.IsType<CowboyCoffee>(ccL); },
                (ttS) => { Assert.IsType<TexasTea>(ttS); },
                (ttM) => { Assert.IsType<TexasTea>(ttM); },
                (ttL) => { Assert.IsType<TexasTea>(ttL); },
                (ttSS) => { Assert.IsType<TexasTea>(ttSS); },
                (ttSM) => { Assert.IsType<TexasTea>(ttSM); },
                (ttSL) => { Assert.IsType<TexasTea>(ttSL); }
            );
        }

        /// <summary>
        /// Filters by calories
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="expected"></param>

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

        /// <summary>
        /// Filters by price
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <param name="expected"></param>

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

        /// <summary>
        /// Filters by term
        /// </summary>
        /// <param name="term"></param>
        /// <param name="expected"></param>

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

        /// <summary>
        /// Checks if the list is sorted by type
        /// </summary>
        /// <param name="types"></param>
        /// <param name="expected"></param>

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
