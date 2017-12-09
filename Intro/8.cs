int matrixElementsSum(int[][] matrix) {
    int r = 0;
    for(int i = 0; i < matrix[0].Length; i++)
        for(int j = 0; j < matrix.Length && matrix[j][i] > 0; j++)
             r += matrix[j][i];
    return r;
}
