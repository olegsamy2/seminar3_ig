// Доп. задача
// Написать программу для разворота массива


Console.Write("Введите количество элементов массива: ");		
int Length = int.Parse(Console.ReadLine());		
		
int i;		
int [] array = new  int[Length];		
Random rand = new Random(); // переменная, что б уйти от выделения памяти в цикле		
		
for(i=0; i < array.Length;i++ )  // заполнения массива		
{		
    array[i] = rand.Next(0,10); // заполняется созданный массив случайными числами от 0 до 9		
   		
}		
		
      Console.WriteLine("\n массив заполняется случайными числами от 1 до 9");		
      Console.WriteLine(string.Join(" , ", array));		
		
for (i = 0; i < array.Length / 2; i++)  // переворот зеркальный элементов массива до середины массива (array.Length / 2)		
{		
    int temp = array[i];                     // перемещение зеркальных значений элементов массива 		
    array[i] = array[array.Length - i - 1];  //  при помощи временной переменной		
    array[array.Length - i - 1] = temp;		
}		
      Console.WriteLine("\n разворот массива - зеркальный метод");		
      Console.WriteLine(string.Join(" , ", array));		
