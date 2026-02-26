class Solution:
    def rotate(self, matrix: List[List[int]]) -> None:
        """
        Do not return anything, modify matrix in-place instead.
        """
        #transpose
        n = len(matrix)
        for i in range(n):
           for k in range(i,n):
            temp = matrix[i][k]
            matrix[i][k] = matrix[k][i]
            matrix[k][i] = temp
        
        for i in range(n):
            matrix[i] = matrix[i][::-1]
        return matrix

        
