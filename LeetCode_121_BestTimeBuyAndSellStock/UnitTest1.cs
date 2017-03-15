using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void price_is_empty_maxProfit_should_be_0()
        {
            var prices = new int[] { };
            AssertMaxProfitShouldBe(prices, 0);
        }
    }

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            return FindMaxProfitFromNextPrice(prices[0], prices.Skip(1), 0);
        }

        private int FindMaxProfitFromNextPrice(int flag, IEnumerable<int> remainPrices, int lastMaxProfit)
        {
            if (!remainPrices.Any())
            {
                return lastMaxProfit;
            }

            var max = remainPrices.Max();
            var currentMaxProfit = max - flag;
            var maxProfit = Math.Max(lastMaxProfit, currentMaxProfit);
            return FindMaxProfitFromNextPrice(remainPrices.ElementAt(0), remainPrices.Skip(1), maxProfit);
        }
    }
}