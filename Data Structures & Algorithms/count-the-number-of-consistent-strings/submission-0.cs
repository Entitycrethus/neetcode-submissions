public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {

        int[] code = new int[26];

        int count = 0;

        foreach(char c in allowed){
            code[c - 'a']=1;
        }   

        foreach(string s in words){
            bool consistent = true;

                foreach(char c in s){
                    if( code[c-'a'] == 0){
                        consistent = false;
                    }
                }    
            if(consistent){
                count++;
            }

        }
        
        return count;


    }
}