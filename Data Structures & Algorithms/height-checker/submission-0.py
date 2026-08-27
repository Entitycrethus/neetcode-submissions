class Solution:
    def heightChecker(self, heights: List[int]) -> int:
        count = 0

        sorted_h = sorted(heights)

        for i in range(len(heights)):
            if(sorted_h[i] != heights[i]):
                count+=1

        return count        