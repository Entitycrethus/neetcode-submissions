public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary < int , int> numsMap = new();

        for (int i = 0 ; i < nums.Length ; i++){

            int complemento = target - nums[i];

            if(numsMap.ContainsKey(complemento)){
                return new int[]{numsMap[complemento] , i};
            }

            else{
                numsMap[nums[i]] = i;
            }
        }

        return [];

    }
}
