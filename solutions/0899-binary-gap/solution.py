class Solution:
    def binaryGap(self, n: int) -> int:
        x = bin(n)[2:]
        max = 0 
        for i in range(len(x)):
            if x[i]== '1':
                for k in range(1,len(x) - i):
                    if x[i+ k] == '1':
                        if k  > max:
                            max = k 
                        break 
        return max
                



        
