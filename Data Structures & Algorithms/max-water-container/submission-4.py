class Solution:
    def maxArea(self, heights: List[int]) -> int:
        
        l , r = 0 , len(heights) - 1 

        areaMax = 0

        while(l < r):
            base = r - l

            height = min(heights[l] , heights[r])

            area =  base * height

            areaMax = max(areaMax , area)

            if( heights[l] > heights[r]):
                r-=1
            else:
                l+=1
        
        return areaMax