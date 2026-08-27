class Solution:

    def encode(self, strs: List[str]) -> str:
        res = []

        for s in strs:
            res.append(str(len(s)))
            res.append('#')
            res.append(s)

        return "".join(res)

    def decode(self, s: str) -> List[str]:
        
        i = 0
        res = []
        j = i
            
        while( i < len(s)):

         
           

            while( s[j] != '#'):
                j+=1

            length   = int(s[i :j])

            j+=1
            i=j
            j= j + length

            res.append(s[i :j])

            i = j
            

        return res

        

