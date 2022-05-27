// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int[] array= new int[8];
for (int i=1; i<=8; i++)
{
    array[i-1]=new Random().Next(0,2);
}
Console.WriteLine();
printArray(array);
void printArray(int[] array)
{
    for (int i=0; i<array.Length;i++)
  {
    Console.Write(array[i] + " ");
  } 
}  
