// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine()); 
int i = 0;
int sum = 0;
int[] array = new int[N];
Random rand = new Random();
for (i=0; i<N; i++)
{
    array[i]=rand.Next();
}
int Sum(int N, int i,int sum)
{
for (i = 0; i < N; i+=2)
{
    sum = sum + array[i];
}
return sum;
}
sum = Sum(N, i, sum);
for (i =0; i < N; i++)
{   
    Console.WriteLine($"{array[i]}"); 
}
Console.WriteLine();
Console.WriteLine($"{sum}");