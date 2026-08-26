class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        
        nums_dict={};

        for i in range (len(nums)):
            complement = target - nums[i]

            if(complement not in nums_dict):
                nums_dict[nums[i]] = i
            else:
                return [nums_dict[complement] , i ]
            


        return []




