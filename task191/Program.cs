// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.	
// 14212 -> нет	
// 12821 -> да	
// 23432 -> да	

//   1 способ - строковый 

Console.WriteLine("Введите пятизначное число: ");

int N = Convert.ToInt32(Console.ReadLine());
string numberText = N.ToString();

if (numberText.Length == 5)

{
    if (numberText[0] == numberText[4] && numberText[1] == numberText[3])
    {
        Console.WriteLine(numberText + " -> да, это палиндром");
    }
    else
    {
        Console.WriteLine(numberText + " -> нет, это не палиндром");
    }
}
else
{
    Console.WriteLine("Введено не пятизначное число");
}
