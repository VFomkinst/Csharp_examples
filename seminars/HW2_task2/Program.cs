int X = Convert.ToInt32(Console.ReadLine());
int Y = Convert.ToInt32(Console.ReadLine());

if(X > 0 && Y > 0){
  Console.WriteLine("Находимся в первой координатной четверти");
}else if(X < 0 && Y > 0){
  Console.WriteLine("Находимся во второй координатной четверти");
}else if(X < 0 && Y < 0){
  Console.WriteLine("Находимся в третьей координатной четверти");
}else{
  Console.WriteLine("Находимся в четвертой координатной четверти");
}
