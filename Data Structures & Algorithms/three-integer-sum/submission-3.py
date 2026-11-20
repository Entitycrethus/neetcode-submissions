class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:

        res=[]
        nums.sort()
        
        for i in range(len(nums)):
            
            if( i> 0  and nums[i] == nums[i-1]):
                continue

            main = nums[i]
            l= i+1
            r= len(nums) - 1

            while( l < r):
                if main + nums[l] + nums[r] > 0:
                    r-=1
                elif main + nums[l] + nums[r] < 0:
                    l+=1
                else:
                    res.append([main, nums[l] ,nums[r]])
                    l+=1
                    while(nums[l] == nums[l-1] and l < r):
                        l+=1
                

        
        return res