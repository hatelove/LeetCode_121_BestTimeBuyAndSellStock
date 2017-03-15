using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LeetCode_121_BestTimeBuyAndSellStock
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void prices_is_5_4_maxProfit_should_be_0()
        {
            var prices = new int[] { 5, 4 };
            AssertMaxProfitShouldBe(prices, 0);
        }

        private static void AssertMaxProfitShouldBe(int[] prices, int expected)
        {
            Assert.AreEqual(expected, new Solution().MaxProfit(prices));
        }

        [TestMethod]
        public void prices_is_4_6_maxProfit_should_be_2()
        {
            var prices = new int[] { 4, 6 };
            AssertMaxProfitShouldBe(prices, 2);
        }

        [TestMethod]
        public void prices_is_4_6_7_maxProfit_should_be_3()
        {
            var prices = new int[] { 4, 6, 7 };
            AssertMaxProfitShouldBe(prices, 3);
        }

        [TestMethod]
        public void prices_is_4_7_6_MaxProfit_should_be_3()
        {
            var prices = new int[] { 4, 7, 6 };
            AssertMaxProfitShouldBe(prices, 3);
        }

        [TestMethod]
        public void price_is_4_7_6_9_3_maxProfit_should_be_5()
        {
            var prices = new int[] { 4, 7, 6, 9, 3 };
            AssertMaxProfitShouldBe(prices, 5);
        }

        [TestMethod]
        public void price_is_4_1_7_maxProfit_should_be_6()
        {
            var prices = new int[] { 4, 1, 7 };
            AssertMaxProfitShouldBe(prices, 6);
        }
    }

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            var remainPrices = prices.Skip(1);
            var max = remainPrices.Max();

            if (prices[1] <= prices[0])
            {
                var flag = prices[1];
                var result = max - flag;
                return result;
            }
            else
            {
                var flag = prices[0];
                var result = max - flag;
                return result;
            }
        }
    }
}