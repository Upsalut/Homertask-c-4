// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] mainArray= new int[10];
int[] array=new int[5];
int mainLength=mainArray.Length;
int arrayLength=array.Length;
int reverse=mainLength-1;
Console.WriteLine("Таблица произведений массива: "); 
for (int i=0; i<mainLength; i++)
{
 mainArray[i]=new Random().Next(1,10);
} 
for (int j=0; j<arrayLength;j++)
{
 array[j]=mainArray[j]*mainArray[reverse];
 reverse--;
 Console.WriteLine($"{array[j]}");
}
Console.WriteLine();
printArray(mainArray);
void printArray(int[] mainArray)
{
    for (int i=0; i<mainLength;i++)
  {
    Console.Write(mainArray[i] + " ");
  } 
}  
