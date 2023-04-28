/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/

Console.WriteLine("Enter massive size");
int size = int.Parse(Console.ReadLine());

int[] array = new int[size];

FillArray(array);

PrintArray(array);

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    if (i%2 == 1)
    sum = sum + array[i];
}
   

    Console.WriteLine($"sum of elements in odd positions = {sum}");

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(-10,10);
        }
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
