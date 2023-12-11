int num = new Random().Next(1,100000);

Console.WriteLine(num);
int size = 0;
if(num < 10) size = 1;
if(num >= 10 && num < 100) size = 2;
if(num >= 100 && num < 1000) size = 3;
if(num >= 1000 && num < 10000) size = 4;
if(num >= 10000 && num < 100000) size = 5;
if(num == 100000) size = 6;

int[] arr = new int[size];

int i = 0;

while(num > 0){
  if(num < 10){
    arr[i] = num;
    num /=10;
    i++;

  }else{
    arr[i] = num%10;
    num /=10;
    i++;
  }
}

 // for(int j = 0; j < arr.Length; j++){
 //   Console.Write(arr[j] + " ");
 // }


int tmp = 0;
for(int k = 0; k <= (size-1) / 2; k++){
  tmp = arr[k];
  arr[k] = arr[(size-1) - k];
  arr[(size -1) - k] = tmp;
  }

for(int j = 0; j < arr.Length; j++){
  Console.Write(arr[j] + " ");
}
Console.WriteLine();
