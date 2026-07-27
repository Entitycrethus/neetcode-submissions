public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        Dictionary <string , List<string> > res = new ();

        foreach( string s in strs){

            int [] count = new int[26];

                foreach( char c in s ){
                    count[ (int)c - (int)'a']+= 1;
                }
                
                string key = string.Join(",",count);

                if(!res.ContainsKey(key)){
                    res[key] = new List<string>();
                }
               
                res[key].Add(s);             
        }

        return res.Values.ToList();
    }
}
