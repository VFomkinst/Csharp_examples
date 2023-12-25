// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

// {{'h','e','l','l','o},{'w','o','r','l','d'}}

string string_from_char_array(char[,] arr){
  string str = "";
  for(int i = 0; i < arr.GetLength(0);i++){
    for(int j = 0; j < arr.GetLength(1); j++){
      str+=arr[i,j];
    }
  }
  return str;
}

char[,] char_array = new char[,]{{'h','e','l','l','o'},{'w','o','r','l','d'}};

Console.WriteLine(string_from_char_array(char_array));
