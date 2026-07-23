public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet <int> numeros  = new HashSet <int>();

        foreach(int n in nums){
            if(numeros.Contains(n)){
                return true;
            }

            numeros.Add(n);
        }

        return false;


    }
}