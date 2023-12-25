//Задайте строку, состоящую из слов, разделенных пробелами.
//Сформировать строку, в которой слова расположены в обратном порядке.
// В полученной строке слова должны быть также разделены пробелами.


// как и в предыдущей задаче не осталось времени написать свои функции, поэтому использовал имеющиеся
string reverseStr(string  str){
string[] strWord = str.Split(' ');
Array.Reverse(strWord);
return string.Join(" ",strWord);
}

//string str = Console.ReadLine();
string str = "world! Hello,";
string new_str = reverseStr(str);
Console.WriteLine(new_str);
