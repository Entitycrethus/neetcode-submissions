class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        nums_dic = {}

        for i in range(len(nums)):
            complement = target - nums[i]

            if( complement not in nums_dic):
                nums_dic[nums[i]] = i
            else:
                return [ nums_dic[ complement ] , i]


        return []