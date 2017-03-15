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
            Assert.AreEqual(0, new Solution().MaxProfit(prices));
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
