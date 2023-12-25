 //Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

string LowRegister(string str){
  char[] arr = str.ToCharArray();
  for(int i = 0; i < str.Length; i++){
     if (arr[i] >= 'A' && arr[i] <='Z'){
       arr[i] += ' ';
     }
  }
  str = string.Concat(arr);
  return str;
}

string STR = "sjJFHkkFHKHFKkkk";
Console.WriteLine(STR);
//STR = STR.ToLower();
Console.WriteLine(LowRegister(STR));
