// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.	
// 14212 -> нет	
// 12821 -> да	
// 23432 -> да	

//   2 способ - цикл

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numbersave = number;
int reversenumber = 0;

if (number > 9999 && number < 100000)

{
while (number > 0)
{
    int dig = number % 10;   // 1 итерация - последняя цифра числа, 2 итерация - предпоследняя...
    reversenumber = reversenumber * 10 + dig;  // переворот числа 
    number = number / 10;  // действие для выполнения цикла
}
 
 if (numbersave == reversenumber)
 {
    Console.WriteLine(numbersave + " -> да, это палиндром");
    }
else
{
    Console.WriteLine(numbersave + " -> нет, это не палиндром");
}
    }
else
{
    Console.WriteLine("Введено не пятизначное число");
}
