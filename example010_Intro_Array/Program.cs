int Max(int arg1, int arg2, int arg3){
  int res = arg1;
  if(arg2 > res) res = arg2;
  if(arg3 > res) res = arg3;
  return res;
}
int[] arr = {34,33,61,93,74,31,22,57,24};

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
int max = Max(
  Max(arr[0],arr[1],arr[2]),
  Max(arr[3],arr[4],arr[5]),
  Max(arr[6],arr[7],arr[8]));
Console.WriteLine(max);
