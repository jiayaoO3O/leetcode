namespace leetcode
{
    class Solution0121
    {
        //121.买卖股票的最佳时机
        //https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock/
        public int MaxProfit(int[] prices)
        {
            if (prices.Length <= 0)
            {
                return 0;
            }
            int minPrice = prices[0], maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                maxProfit = System.Math.Max(maxProfit, prices[i] - minPrice);
                minPrice = System.Math.Min(minPrice, prices[i]);
            }
            return maxProfit;
        }
    }
}