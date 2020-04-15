using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CowboyCafe.DataTests.UnitTests
{
    public class OrderTests
    {
        public class MockOrderItem : IOrderItem
        {
            public double Price { get; set; }
            public uint Calories { get; set; }
            public List<string> SpecialInstructions { get; set; }
        }

        [Fact]

        //Should be able to add Items

        public void ShouldBeAbleToAddItems()
        {
            var order = new Order();
            var item = new MockOrderItem();

            order.Add(item);
            Assert.Contains(item, order.Items);
        }

        [Fact]

        //Should be able to remove items

        public void ShouldBeAbleToRemoveItems()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }

        [Fact]

        //Should be able to get the list of items

        public void ShouldBeAbleToGetEnumeration()
        {
            var order = new Order();
            var item0 = new MockOrderItem();
            var item1 = new MockOrderItem();
            var item2 = new MockOrderItem();
            order.Add(item0);
            order.Add(item1);
            order.Add(item2);
            Assert.Collection(order.Items,
                item => Assert.Equal(item0, item),
                item => Assert.Equal(item1, item),
                item => Assert.Equal(item2, item));
        }

        [Theory]
        [InlineData(new double[] { 1, 2, 3 })]
        [InlineData(new double[] { 5.65, 6.3})]
        [InlineData(new double[] {})]
        [InlineData(new double[] {-5})]
        [InlineData(new double[] { -4, 10, -3 })]
        [InlineData(new double[] { 1.3453434463464})]
        [InlineData(new double[] { double.NaN })]

        //Subtotal should be sum of prices

        public void ShouldBeSumOfItemPrices(double[] prices)
        {
            var order = new Order();
            double total = 0;
            foreach(var price in prices)
            {
                total += price;
                order.Add(new MockOrderItem()
                {
                    Price = price
                });
            }
            Assert.Equal(total, order.Subtotal);
        }

        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Items")]

        //Add Should trigger PropertyChanged for Items and Price

        public void AddShouldTriggerPropertyChanged(string property)
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, property, () => order.Add(item));
        }

        [Theory]
        [InlineData("Subtotal")]
        [InlineData("Items")]

        //Removing Should trigger PropertyChanged for Items and Price

        public void RemoveShouldTriggerPropertyChanged(string property)
        {
            var order = new Order();
            var item = new MockOrderItem();
            Assert.PropertyChanged(order, property, () => order.Remove(item));
        }
    }
}
