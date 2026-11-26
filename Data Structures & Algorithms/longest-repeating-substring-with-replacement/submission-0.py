class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        l , r = 0 , 0
      
        freqChar={}
        res = 0

        for r in range(len(s)):

            freqChar[s[r]] = freqChar.get(s[r],0) + 1
            subStringLen = r - l + 1
            mostFreqChar = freqChar[max(freqChar , key = freqChar.get)]

            while subStringLen - mostFreqChar > k and l <=r:
                freqChar[s[l]]-=1
                l+=1
                subStringLen = r - l + 1

            res = max(res , subStringLen)

        return res
