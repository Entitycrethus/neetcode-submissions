public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary< int , int > numberFrequency = new Dictionary< int , int>();
        
        foreach( int n in nums){
            if(!numberFrequency.ContainsKey(n)){
                numberFrequency[n]=1;
            }
            else{
                numberFrequency[n]++;
            }
        }

        int [] topKElements = numberFrequency
            .OrderByDescending(pair => pair.Value)
            .Take(k)
            .Select(pair => pair.Key )
            .ToArray();
        
        return topKElements;


    }
}

