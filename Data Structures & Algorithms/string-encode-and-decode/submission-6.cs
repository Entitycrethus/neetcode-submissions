public class Solution {

    public string Encode(IList<string> strs) {
        string res = "";

        foreach( string s in strs){

            string length = s.Length.ToString();

            res+=$"{length}#{s}";
        }

        Console.WriteLine(res);
        return res;
    }

    public List<string> Decode(string s) {
        
        List<string> res = new List<string>();

        int i =  0;

        while( i  < s.Length){
            
            int j = i;

            while(s[j] != '#'){
                j++;
            }

            int length = int.Parse(s.Substring(i, j - i));

            i = j  + 1;
            j= i + length;

            res.Add(s.Substring(i , length));

            i = j;

        }

        return  res;
    }
}


