//Задайте произвольный массив. Выведете его элементы, начиная с конца.
//Использовать рекурсию, не использовать циклы.


 int[] ArraySwap(int [] array,int index){

   if (index < 0){
     return array;
   }
   Console.Write($"{array[index]} ");
   return ArraySwap(array,index - 1);
}

int n = new Random().Next(1,10);
int[] arr = new int[n];

for(int i = 0; i < arr.Length; i++){
  arr[i] = new Random().Next(1,15);
  Console.Write($"{arr[i]} ");

}
Console.WriteLine();
ArraySwap(arr, n - 1);
