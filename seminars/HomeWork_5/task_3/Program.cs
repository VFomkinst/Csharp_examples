// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// информация в интернете сказала, что прямоугольный массив -- это "квадратный" масиив.
void PrintArray(int[,] matr){
  for(int i = 0; i < matr.GetLength(0); i++){
     for (int j = 0; j < matr.GetLength(1); j++){
       Console.Write($"{matr[i,j]} ");
     }
     Console.WriteLine();
  }
}

int SumRow(int row, int[,] arr){
  int sum = 0;
  for(int j = 0; j < arr.GetLength(1); j++){
    sum += arr[row,j];
  }
  return sum;
}
int r = new Random().Next(1,10);

int c = r;

int[,] array = new int[r,c];

for(int i = 0; i < r; i++){
  for(int j = 0; j < c; j++){
    array[i,j] = new Random().Next(1,100);
  }
}
Console.WriteLine("Наш массив");
PrintArray(array);
Console.WriteLine();

int sum = SumRow(0, array);
int MinRow = 0;

for(int i = 0; i < r; i++){
  if(sum > SumRow(i, array)) {
    sum = SumRow(i,array);
    MinRow = i;
  }
}
Console.Write("Строка с наименьшей суммой: ");

for(int j = 0; j < r; j++){
  Console.Write($"{array[MinRow,j]} ");
}
