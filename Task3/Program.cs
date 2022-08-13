//Напишите программу, которая создает массив из введенных через запятую цифр и выводит этот массив на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

//Заполнения массива из строки  
Console.Write("Введите числа: ");
string? seriesOfNumbers = Console.ReadLine();
seriesOfNumbers = seriesOfNumbers + ",";

// заполняет массив значениями из строки
int[] ArrayOfNumbers(string seriesNew)
{ 
    int[] arrayOfNumbers = new int[1];    
    int j = 0;
    for (int i = 0; i < seriesNew.Length; i++)
    {
        string seriesNew1 = "";
        while (seriesNew[i] != ',' && i < seriesNew.Length)
        {
            seriesNew1 += seriesNew[i];
            i++;
            }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    
    if (i < seriesNew.Length-1)
    {
        arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();
    }
    j++;
  }
  return arrayOfNumbers;
}
// Вывод массива на печать 
void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 

int[] arrayOfNumbers =  ArrayOfNumbers(seriesOfNumbers);
PrintArry(arrayOfNumbers);