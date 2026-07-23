public class Solution {
    public bool IsAnagram(string s, string t) {

       char [] arrayS = s.ToCharArray();
       Array.Sort(arrayS);

       char [] arrayT = t.ToCharArray();
       Array.Sort(arrayT);

       return arrayS.SequenceEqual(arrayT) ? true : false;
    }
}
