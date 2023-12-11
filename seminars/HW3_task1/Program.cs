int [] arr = new int[10];
int  i = 0;
while( i < 10){
  arr[i] = new Random().Next(1,100);
  i++;
}

int count = 0;

for(int j = 0; j < 10; j++){
  if(arr[j] >= 20 && arr[j] <= 90) count++;
}

Console.WriteLine(count);
// for(int j = 0; j < 10; j++){
//   Console.Write(arr[j] + " ");
// }
