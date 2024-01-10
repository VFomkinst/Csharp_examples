 //Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
 //Использовать рекурсию, не использовать циклы.

void NaturalNumber(int m, int n){
  if(m == n){
    Console.Write(m);
  }
  else if(m < n){
      Console.Write($"{m} ");
      NaturalNumber(m+1, n);
    }else {
        Console.Write($"{n} ");
        NaturalNumber(m , n + 1);
    }
}

int M = Convert.ToInt32(Console.ReadLine());
//int M = new Random.Next(1,1000);
int N = Convert.ToInt32(Console.ReadLine());
//int N = new Random.Next(1,1000);
NaturalNumber(M,N);
