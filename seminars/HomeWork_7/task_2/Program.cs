//Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.

int Ackerman(int m, int n){
  if(m == 0){
     return n + 1;
  }else{
    if(n == 0){
      return Ackerman(m - 1, 1);
    }else{
      return Ackerman(m - 1, Ackerman(m, n - 1));
    }
  }
}

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Значение функции Аккермана при f({M},{N}) = {Ackerman(M,N)}");
