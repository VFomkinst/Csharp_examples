// string[,] table = new string [2,5];
//
// table [1,2] = "vsiudhfds";

// for(int row = 0; row < 2; row++){
//   for (int col =0; col < 5; col++) {
//     Console.WriteLine($"-{table[row;col]}-");
//   }
// }

void PrintArray(int[,] matr){
  for(int i = 0; i < matr.GetLength(0); i++){
     for (int j = 0; j < matr.GetLength(1); j++){
       Console.Write($"{matr[i,j]} ");
     }
     Console.WriteLine();
  }
}
void Fillarray(int[,] matr){
  for(int i = 0; i < matr.GetLength(0); i++){
     for (int j = 0; j < matr.GetLength(1); j++){
       matr[i,j] = new Random().Next(1,10);
     }
  }

}

int[,] matrix = new int[3,4];
Fillarray(matrix);
PrintArray(matrix);
