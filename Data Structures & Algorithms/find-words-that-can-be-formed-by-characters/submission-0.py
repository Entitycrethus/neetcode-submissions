class Solution:
    def countCharacters(self, words: List[str], chars: str) -> int:
        count = 0
       

        for s in words:
            valid = True
            code = [0]*26
            for c in s:
                code[ord(c) - ord('a')] +=1
        
            for c in chars:
                code[ord(c) - ord('a')] -=1

            for val in code:
                if(val > 0):
                    valid = False
            
            if valid:
                count+=len(s)
                valid = True

        return count
        