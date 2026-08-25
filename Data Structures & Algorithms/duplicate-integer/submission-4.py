class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        nums_set : set[int] = set()

        for n in nums:

            if n not in nums_set: 
                nums_set.add(n)
            

            else:
                return True
            

        return False