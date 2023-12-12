//Напишите программу, которая бесконечно запрашивает целые числа с консоли.
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

//int num = Convert.ToInt32(Console.ReadLine());


while(true){
  Console.WriteLine("Введите число ");
  string str = Console.ReadLine();

  if(str == "q"){
    break;
  }
  int sum = 0;
  int num = Convert.ToInt32(str);
  if(num != 0){
    while(num != 0){
      sum += num%10;
      num /=10;
    }
    if(sum%2 == 0){
      break;
    }else{
      sum = 0;
    }
  }
}
