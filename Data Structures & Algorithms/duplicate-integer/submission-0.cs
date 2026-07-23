public class Solution {
    public bool hasDuplicate(int[] nums) {
        for( int i = 0 ; i < nums.Length ; i++){    
            if( i + 1 < nums.Length){
                for( int j = i + 1 ; j < nums.Length ; j ++){
                    if( nums[i] == nums[j]){
                        return true;
                    } 
                }
            } 
        }
        return false;
    }
}