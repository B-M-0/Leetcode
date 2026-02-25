class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:
        carry = 1
        for i in range(1,len(digits)+1):
            x = digits[-i] + carry 
            digits[-i]= x % 10
            carry = x // 10
            if i == len(digits)  and carry != 0:
                digits = [carry] + digits

        return digits
        
