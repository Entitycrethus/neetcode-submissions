class Solution:
    def maxArea(self, heights: List[int]) -> int:

        l , r = 0 , len(heights) - 1

        aMax = 0

        while l < r:

            b = r - l
            h = min(heights[l] , heights[r])

            cArea = b * h

            aMax = max(aMax , cArea)

            if heights[l] > heights[r]:
                r-=1
            elif heights[r] > heights[l]:
                l+=1
            else:
                l+=1

        return aMax
 
