// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int minArray = 100;
int maxArray = 999;

Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine()); 
int i = 0;
int count = 0;
int[] array = new int[N];
Random rand = new Random();
for (i=0; i<N; i++)
{
    array[i]=rand.Next(minArray, maxArray);
}
int chet(int N, int i, int count)
{
    for (i = 0; i< N; i++)
{
    if (array[i] % 2 == 0)
    {
     count++;   
    }
}
return count;
}
count = chet(N, i, count);
for (i =0; i < N; i++)
{   
    Console.WriteLine($"{array[i]}"); 
}
Console.WriteLine($"{count}");