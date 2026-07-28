public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        Dictionary <string , List<string> > res = new ();

        foreach( string s in strs){

            int [] count = new int[26];

                foreach( char c in s ){
                    count[ (int)c - (int)'a']+= 1;
                }
                
                char[] keyChars = new char[26];

                for (int i = 0; i < 26; i++) {
                keyChars[i] = (char)(count[i] + 'a'); // codifica el número como letra
                }

                string key = new string(keyChars);

                if(!res.ContainsKey(key)){
                    res[key] = new List<string>();
                }
               
                res[key].Add(s);             
        }

        return res.Values.ToList();
    }
}
