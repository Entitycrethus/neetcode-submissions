public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
         Dictionary <int , int> numsMap = new();
		 
		 foreach( int n in nums){
		 	if(!numsMap.ContainsKey(n)){
				numsMap[n] = 1;
			}else{
				numsMap[n]++;
			}
		 }
		 
		 var valuesFiltrados = numsMap.OrderByDescending( kvp => kvp.Value).Take(k).Select(kvp => kvp.Key).ToArray();
		 
		 
 		 return valuesFiltrados;
    }
}
