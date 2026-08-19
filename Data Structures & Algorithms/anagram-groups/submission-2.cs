public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string ,  List<string>> res = new();

        foreach( string s in strs){

            int[] codification = new int[26];


            foreach(char c in s){
                codification[ c - 'a']++;
            }

            string key =string.Join(",",codification);

            if(!res.ContainsKey(key)){
                res[key]=new List<string>();
                res[key].Add(s);
            }else{
                res[key].Add(s);
            }
        }

        return res.Values.ToList();
    }
}
