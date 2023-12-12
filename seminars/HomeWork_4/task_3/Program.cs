// Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.)
int[] ReversArray(int[] mass){
  int size = mass.Length;
  int tmp;
  for(int k = 0; k <= (size-1) / 2; k++){
    tmp = mass[k];
    mass[k] = mass[(size-1) - k];
    mass[(size -1) - k] = tmp;
    }
    return mass;
}

int[] arr = new int[10];

for(int i = 0; i < arr.Length; i++){
  arr[i] = new Random().Next(100,999);
}

for(int i = 0; i < arr.Length; i++){
   Console.Write(arr[i] + " ");
}
Console.WriteLine("\nНебольшая магия и вуаля");

arr = ReversArray(arr);

for(int i = 0; i < arr.Length; i++){
   Console.Write(arr[i] + " ");
}
