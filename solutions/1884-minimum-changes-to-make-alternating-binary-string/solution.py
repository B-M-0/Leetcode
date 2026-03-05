class Solution:
    def minOperations(self, s: str) -> int:
        count1 = 0
        count0 = 0
            
        if(s[0]=="0"):
            count1+=1
        else:
            count0+=1
        for i in range(1,len(s)):
            if(i+1) %2 == 1 and s[i] =='0':
                count1 +=1
            elif(i+1) %2 == 0 and s[i] =='1':
                count1 +=1
    
        for i in range(1,len(s)):
            if(i+1) %2 == 1 and s[i] =='1':
                count0 +=1
            elif(i+1) %2 == 0 and s[i] =='0':
                count0 +=1


        return min(count1,count0)
        
