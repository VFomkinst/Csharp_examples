// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// void PrintArray(int[,] matr){
//   for(int i = 0; i < matr.GetLength(0); i++){
//      for (int j = 0; j < matr.GetLength(1); j++){
//        Console.Write($"{matr[i,j]} ");
//      }
//      Console.WriteLine();
//   }
// }

int r = new Random().Next(1,10);

int c = new Random().Next(1,10);

//Console.WriteLine($"{r}  {c}");
int[,] array = new int[r,c];

for(int i = 0; i < r; i++){
  for(int j = 0; j < c; j++){
    array[i,j] = new Random().Next(1,100);
  }
}

Console.Write("Введите 1 число: ");

int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число: ");

int col = Convert.ToInt32(Console.ReadLine());


if(row > r || row < 0 || col > c || col < 0){
  Console.WriteLine("Такого элемента нет");
}
else{
  Console.WriteLine(array[row - 1,col - 1]);
}
//PrintArray(array);
