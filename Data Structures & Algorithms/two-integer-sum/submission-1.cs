public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary <int , int> numbers = new ();
		
		for(int i = 0 ; i < nums.Length ; i++ ){
			
			int complemento = target - nums[i];

			if(numbers.ContainsKey(complemento)){
				return new int[]{numbers[complemento] ,i };
			}	
			if(!numbers.ContainsKey(nums[i])){
				numbers[nums[i]] = i;
			}		
			
		}
		
		return new int []{};
    }
}
