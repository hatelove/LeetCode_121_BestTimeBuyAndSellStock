using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices[1] <= prices[0])
            {
                return 0;
            }

            throw new NotImplementedException();
        }
    }
}
