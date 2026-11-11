class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:

        anagrams = defaultdict(list)

        for s in strs:
            code = [0] * 27

            for c in s:
                code[ord(c) - ord('a')]+=1

            anagrams[tuple(code)].append(s)
            
        return list(anagrams.values())



        