int Max(int arg1, int arg2, int arg3){
  int res = arg1;
  if(arg2 > res) res = arg2;
  if(arg3 > res) res = arg3;
  return res;
}

int a1 = 34, b1 = 33, c1 = 61;
int a2 = 93, b2 = 74, c2 = 31;
int a3 = 22, b3 = 57, c3 = 24;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
int max = Max(
  Max(a1, b1, c1),
  Max(a2, b2, c2),
  Max(a3, b3, c3));
Console.WriteLine(max);
