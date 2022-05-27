// Задать массив из 12 элементов, заполненных числами из [0,9].
// Найти сумму положительных/отрицательных элементов массива
int[] array= new int[12];
int resultPlus=0;
int resultMinus=0;
for (int i=1; i<=12; i++)
{
    array[i-1]=new Random().Next(-10,10);
    if (array[i-1]>0)
    {
     resultPlus=resultPlus+array[i-1];
    }
    else if(array[i-1]<0)
    {
     resultMinus=resultMinus+array[i-1];
    } 
}
Console.WriteLine($"Сумма положительных = {resultPlus}");
Console.WriteLine($"Сумма отрицательных = {resultMinus}");
Console.WriteLine();
printArray(array);
void printArray(int[] array)
{
    for (int i=0; i<array.Length;i++)
  {
    Console.Write(array[i] + " ");
  } 
}  
