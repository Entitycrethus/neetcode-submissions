class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        l , r = 0 , 1 
        profit = 0

        while r < len(prices):

            if prices[l] > prices[r]:
                l = r
                r+=1
            else:
                cProfit = prices[r] - prices[l]
                profit = max(cProfit , profit)
                r+=1
        
        return profit