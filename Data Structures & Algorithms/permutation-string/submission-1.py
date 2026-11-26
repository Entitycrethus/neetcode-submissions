class Solution:
    def checkInclusion(self, s1: str, s2: str) -> bool:

        if len(s1) > len(s2):
            return False
        

        dictS1 , dictS2 = {} , {}
        l , r = 0 , len(s1) - 1

        for i in range (len(s1)):
            dictS1[s1[i]] = dictS1.get(s1[i] , 0) + 1
            dictS2[s2[i]] = dictS2.get(s2[i] , 0) + 1
        
        while r < len(s2) - 1:

            if dictS1 == dictS2:
                return True

            r+=1
            dictS2[s2[r]] = dictS2.get(s2[r] , 0) + 1
            dictS2[s2[l]] = dictS2.get(s2[l] , 0) - 1
            if dictS2[s2[l]] == 0:
                del dictS2[s2[l]]
            l+=1  
              
        return dictS1 == dictS2


            




        
        

        