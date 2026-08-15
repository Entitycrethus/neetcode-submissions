public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }

        int[] countS = new int[26];
        int[] countT = new int[26];

        for(int i = 0 ; i < s.Length ; i++){

            countS[s[i] - 'a']++;

            countT[t[i] - 'a']++;
        }

        return countS.SequenceEqual(countT);

    }
}
