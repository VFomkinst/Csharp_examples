// Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int CountEven(int[] mass){
  int count = 0;

  for(int i = 0; i < mass.Length; i++){
    if(mass[i]%2 == 0) count++;
  }

  return count;
}


int[] arr = new int[10];

for(int i = 0; i < arr.Length; i++){
  arr[i] = new Random().Next(100,999);
}
Console.WriteLine(CountEven(arr));

// for(int i = 0; i < arr.Length; i++){
//   Console.Write(arr[i] + " ");
// }
