//Задайте произвольную строку. Выясните, является ли она палиндромом.
//палиндром --  число, буквосочетание, слово или текст, одинаково читающееся в обоих направлениях

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

string LetterOrDigit(string str){
  char[] arr = str.ToCharArray();
  char[] new_arr = new char[str.Length];
  for(int i = 0; i < str.Length; i++){
    int count = 0;
     if ((arr[i] >= 'A' && arr[i] <='Z') ||
         (arr[i] >= '0' && arr[i] <='9') ||
         (arr[i] >= 'a' && arr[i] <='z') ||
         (arr[i] >= 'А' && arr[i] <='п') ||
         (arr[i] >= 'р' && arr[i] <='ё')){

       new_arr[i - count] = arr[i];
     }else{
       count++;
     }
  }
  str = string.Concat(new_arr);
  //Console.WriteLine(str);
  return str;

}

bool Palindrom(string str){
  string new_str = LowRegister(str);
  new_str = LetterOrDigit(new_str);
  //Console.WriteLine(new_str.SequenceEqual(new_str.Reverse()));
  //тут уже не было времени писать свою функцию
  return new_str.SequenceEqual(new_str.Reverse());
}

string str = "(fша0л0ашF)";
//Console.WriteLine(str);
bool palindrome = Palindrom(str);
Console.WriteLine(palindrome ? "yes":"no");
