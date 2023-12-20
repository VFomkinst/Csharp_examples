// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.
void PrintArray(int[,] matr){
  for(int i = 0; i < matr.GetLength(0); i++){
     for (int j = 0; j < matr.GetLength(1); j++){
       Console.Write($"{matr[i,j]} ");
     }
     Console.WriteLine();
  }
}


int r = new Random().Next(1,10);

int c = new Random().Next(1,10);

int[,] array = new int[r,c];

for(int i = 0; i < r; i++){
  for(int j = 0; j < c; j++){
    array[i,j] = new Random().Next(1,100);
  }
}

PrintArray(array);
Console.WriteLine("\n");

int tmp;
int last_row = array.GetLength(0) - 1;

for(int j = 0; j < array.GetLength(1); j++){
    tmp = array[0,j];
    array[0,j] = array[last_row,j];
    array[last_row,j] = tmp;
}
PrintArray(array);
