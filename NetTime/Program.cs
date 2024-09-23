class NetTime
    {
  public boolean serchMatrix(int[][] matrix, int k) {
    if (matrix == null || matrix.length == 0 || matrix[0].length == 0){
       }
    }
  int[,] array = new int[4, 3]; // 4 строки, 2 столбца
for (int i=1; i <= N, i++) { 
    for (int j=1; j <= N, j++) { 
        Console.Write(A[i, j] + " ");
        }
      Console.WriteLine(); // переход на новую строку 
          int[,] array = new int[n,m];                                
          for (int i = 0; i <  n; i++)
          {
       string A = Console.ReadLine();                         // считываем строку 
       int[] curr = A.Split(' ').Select(int.Parse).ToArray(); // преобразуем эту строку в одномерный массив curr
       for (int j = 0; j < m; j++)
           {
           array[i, j] = curr[j];                             // заполняем строку нужного нам массива значениями из массива curr
           }
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
