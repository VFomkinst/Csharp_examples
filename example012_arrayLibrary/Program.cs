void FillArray(int [] collection){

  int lenght = collection.Length;
  int index = 0;
  while(index < lenght){

    collection[index] = new Random().Next(1,10);
    index++;

  }
}

void PrintArray(int [] col){
  int count = col.Length;
  int pos = 0;

  while(pos <  count){

    Console.WriteLine(col[pos]);
    pos++;
  }
}

int IndexOf(int[] collection, int find){
  int count = collection.Length;
  int index = 0;
  int pos = -1;
  while(index < count){
    if(collection[index] == find){
      pos = index;
      break;
    }
    index++;
  }
  return pos;
}

int[] arr = new int[10];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
int pos = IndexOf(arr,4);
Console.WriteLine(pos);
