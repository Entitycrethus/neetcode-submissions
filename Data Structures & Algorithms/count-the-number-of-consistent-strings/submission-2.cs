public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        int mask = 0;

        foreach( char c in allowed){
            mask = mask | (1<< (c - 'a'));
        }

        int count = 0;

        foreach( string s in words){

            bool consistent = true;

            foreach ( char c in s){

                if((mask & (1 << (c - 'a')))== 0 ){
                    consistent = false;
                    break;
                }
            }

            if(consistent)count++;
        }

        return count;
    }

    
}