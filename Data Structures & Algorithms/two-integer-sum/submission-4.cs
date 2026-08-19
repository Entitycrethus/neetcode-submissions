public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,  int> numsMap = new();

        for ( int i = 0 ; i < nums.Length  ; i++){
            int complement = target - nums[i];

            if(!numsMap.ContainsKey(complement)){
                numsMap[nums[i]] = i;
            }

            else{
                return new int[]{numsMap[complement] , i};
            }
        }

        return [];
    }
}
