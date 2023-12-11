int num = Convert.ToInt32(Console.ReadLine());


if(mun >= 10 && num <=99){

  int dec = num%10;
  num /= 10;

  if(num > dec){
    Console.WriteLine(num);
  }else if (num < dec){
    Console.WriteLine(dec);
  }else{
    Console.WriteLine(num);
  }
}
