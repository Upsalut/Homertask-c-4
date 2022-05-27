//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] array= new int[10];
int even=0;
int odd=0;
for (int i=0; i<array.Length; i++)
{
    array[i]=new Random().Next(100,1000);
    if (array[i]%2==0)
    {
    even++;
    }
    else if(array[i]%2!=0)
    {
    odd++;
    } 
}
Console.WriteLine($"Количество четных = {even}");
Console.WriteLine($"Количество нечетных = {odd}");
Console.WriteLine();
printArray(array);
void printArray(int[] array)
{
    for (int i=0; i<array.Length;i++)
  {
    Console.Write(array[i] + " ");
  } 
}  
