public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
		Dictionary<int , int> numsMap = new ();

		List<int> [] freq = new List<int>[nums.Length + 1 ];

		for ( int i = 0 ; i < freq.Length ; i++)
		{
			freq[i] = new List<int>();
		}

		foreach( int number in nums){
			if(!numsMap.ContainsKey(number)){
				numsMap[number] = 1;
			}else{
				numsMap[number]++;
			}
		}

		foreach(var kvp in numsMap){
			freq[kvp.Value].Add(kvp.Key);
		} 	

		int[] res = new int[k];
		int index = 0;

		for(int i = freq.Length - 1 ; i > 0 && index < k ; i--){

			foreach(int n in freq[i]){
				res[index++] = n;
				if(index  == k ){
					return res;
				}
			}
		}

		return res;



    }
}
