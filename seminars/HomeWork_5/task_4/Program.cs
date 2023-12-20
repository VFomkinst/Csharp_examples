// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Под удалением понимается создание нового двумерного массива без строки и столбца
void PrintArray(int[,] matr){
  for(int i = 0; i < matr.GetLength(0); i++){
     for (int j = 0; j < matr.GetLength(1); j++){
       Console.Write($"{matr[i,j]} ");
     }
     Console.WriteLine();
  }
}
 int[] SearchMin(int[,] arr){
   int[] rc = new int[2];
   int min = arr[0,0];
   for(int i = 0; i < arr.GetLength(0); i++){
     for(int j = 0; j < arr.GetLength(1); j++){
       if(min > arr[i,j]){
         rc[0] = i;
         rc[1] = j;
         min = arr[i,j];
       }
     }
   }
   Console.WriteLine($"минимальный элемент {min} и его координаты {rc[0]}, {rc[1]}");
   return rc;
 }
int[,] NewArray(int[,] arr, int row, int col){

  int flag1 = 0;
  int flag2 = 0;

  int[,] NewArr = new int[arr.GetLength(0) -1, arr.GetLength(1) - 1];
  //Console.WriteLine($"Новый массив рамером [{arr.GetLength(0) -1},{arr.GetLength(1) -1}]");
  for(int i = 0; i < NewArr.GetLength(0); i++){
    if(i == row) flag1 = 1;
    for(int j = 0; j <NewArr.GetLength(1); j++){
      if(j == col) flag2 = 1;
      NewArr[i, j] = arr[i+flag1,j+flag2];
      }
      flag2 = 0;
  }
  return NewArr;
}

int r = new Random().Next(1,10);

int c = new Random().Next(1,10);

int[,] array = new int[r,c];

for(int i = 0; i < r; i++){
  for(int j = 0; j < c; j++){
    array[i,j] = new Random().Next(1,100);
  }
}
Console.WriteLine("Исходный массив:");
PrintArray(array);
int[] coord = SearchMin(array);
//Console.WriteLine("new array");
int[,] newArr = NewArray(array, coord[0],coord[1]);
Console.WriteLine("Новый массив");
PrintArray(newArr);
