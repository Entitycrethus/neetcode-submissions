public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hashNums = new ();

        foreach(int num in nums){

            if(hashNums.Contains(num)){
                return true;
            }else{
                hashNums.Add(num);
            }
        }

        return false;
    }
}