class Solution:
    def maxArea(self, heights: List[int]) -> int:

        areaMax = 0
        l = 0 
        r = len(heights) - 1

        while ( l < r):
            
            area = (r - l) * min(heights[l],heights[r])
            areaMax = max(areaMax,area)

            if heights[l] < heights[r]:
                l+=1
            elif heights[l] > heights[r]:
                r-=1
            else:
                l+=1

        return areaMax

        