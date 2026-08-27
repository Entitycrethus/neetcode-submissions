class Solution:
    def numIdenticalPairs(self, nums: List[int]) -> int:
        res = 0

        count = Counter(nums)

        for num , c in count.items():
            res += c * (c - 1) //2

        return res