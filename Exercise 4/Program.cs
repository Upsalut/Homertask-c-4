//В одномерном массиве из 123 чисел найти количество (сумму??) элементов из отрезка [10,99]
int[] array= new int[123];
int count=0;
int left=10;
int right=100;
for (int i=0; i<array.Length; i++)
{
    array[i]=new Random().Next(1,10);
    if(i>=left && i<right)
    {
        count+=array[i];
        i++;
    }
}
Console.WriteLine($"Сумма элементов от 10 до 99 = {count}");
Console.WriteLine();
printArray(array);
void printArray(int[] array)
{
    for (int i=0; i<array.Length;i++)
  {
    Console.Write(array[i] + " ");
  } 
}  

