double[] array = new double[10];

Random rand = new Random();

for (int i = 0; i < array.Length; i++)
array[i] = rand.NextDouble() * 100;

double max = array[0];
double min = array[0];
 // for (int j = 0; j < 10; j++) {
 //    Console.Write(string.Format("{0:0.00}",array[j]) + "  ");
 // }
 //
 // Console.WriteLine();

for(int i = 1; i < 10; i++){
  if(array[i] > max) max = array[i];
  if(array[i] < min) min = array[i];
 }
 Console.WriteLine(max + " " + min);
