int num = Convert.ToInt32(Console.ReadLine());

while(num > 0){
  Console.Write(num%10);
  num /=10;
  if (num > 0) Console.Write(", ");
}
