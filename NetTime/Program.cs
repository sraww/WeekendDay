class NEtTime
{
  public boolean serchMatrix(int[][] matrix, int k) {
    if (matrix == null || matrix.length == 0 || matrix[0].length == 0){
    }
}
 int m = matrix.length, n = matrix[0].length;
 int i = 0, j = n - 1;




  while (i< m && j>=0) 
  {
 if (matrix[i][j] == k) {
    return = true;
 }
     if (matrix[i][j] > k) {
    j--;
     }
       else;
    {
    i++;
    }
  }
  return false;
}
}
