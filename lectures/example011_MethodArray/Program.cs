int[] arr = {34,33,61,93,74,31,22,57,24};

int n = arr.Length;
int find = 31;
int index = 0;
while(index < n){
  if(arr[index] == find) {
    Console.WriteLine(index);
    break;
  }
  index++;
}
