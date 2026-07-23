public class Solution {
   public  bool IsAnagram(string s, string t) {
		
		if(s.Length != t.Length){
			return false;
		}
		Dictionary <char , int> countS = new();
		Dictionary <char , int> countT = new();
			
		for(int i = 0 ; i < s.Length ; i++){
			countS[s[i]] = 1 + countS.GetValueOrDefault(s[i]);
			countT[t[i]] = 1 + countT.GetValueOrDefault(t[i]);
		}		
		foreach(var (letra , cantidad) in countS){							
			if(countS.GetValueOrDefault(letra) != countT.GetValueOrDefault(letra)){
	
				return false;
			}
		}
		
		return true;
    }
}
