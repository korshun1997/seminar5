// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine()); 
int i = 0;
double sum = 0;
double[] array = new double[N];
Random rand = new Random();
for (i=0; i<N; i++)
{
    array[i]=rand.Next();
}
double min = array[0]; 
double max = array[0];
double Sum(double max, double min, double sum)
{
 for (i=0; i<N; i++)
{
    if (array[i]> max)
    {
        max = array[i];
    }
    else
     if (array[i]< min)
    {
        min = array[i];
    }
}   
sum = max- min;
return sum;
}
sum =  Sum(max,min,sum);
for (i=0; i<N; i++)
{
    Console.WriteLine($"{array[i]}");
}
Console.WriteLine($"{sum}");