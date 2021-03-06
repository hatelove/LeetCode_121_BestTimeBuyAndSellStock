﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

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

        [TestCategory("from leetcode")]
        [TestMethod]
        public void price_is_empty_maxProfit_should_be_0()
        {
            var prices = new int[] { };
            AssertMaxProfitShouldBe(prices, 0);
        }

        [TestMethod]
        public void prices_is_2_1_2_0_1_maxProfit_should_be_1()
        {
            var prices = new int[] { 2, 1, 2, 0, 1 };
            AssertMaxProfitShouldBe(prices, 1);
        }
    }

    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2)
            {
                return 0;
            }

            return FindMaxProfitByKadane(prices);
        }

        private int FindMaxProfitByKadane(int[] prices)
        {
            var currentSum = 0;
            var maxSum = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                currentSum = Math.Max(0, currentSum += prices[i] - prices[i - 1]); //less than 0, reset to 0
                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
    }
}