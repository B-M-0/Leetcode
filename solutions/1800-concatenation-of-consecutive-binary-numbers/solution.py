class Solution:
    def concatenatedBinary(self, n: int) -> int:
        ls = ""
        for i in range(1,n+1):
            string = bin(i)[2::]
            ls =  ls +string 
        return int(ls,2)  % (10**9 + 7)
        
