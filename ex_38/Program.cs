/*Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.*/

Console.WriteLine("Enter massive size");
int size = int.Parse(Console.ReadLine());

double[] array = new double[size];

double max = array[0];
double min = array[0];

FillArray(array);

PrintArray(array);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}

Console.WriteLine($"Max is {max}, min is {min}");
Console.WriteLine($"Difference between maxi and min value = {max - min}");

void FillArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(-10,10);
        }
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}