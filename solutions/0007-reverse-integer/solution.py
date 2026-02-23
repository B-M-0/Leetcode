class Solution:
    def reverse(self, x: int) -> int:
        y = str(x)[::-1]
        
        out = 0
        if x < 0 :
            out = -1* int(y[:len(y)-1])
        else :
            out = int(y)
        if out < -(2**31)  or out > 2**31:
            return 0
        else:
            return out


        
