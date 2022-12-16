// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
int len = number.Length;

if(len == 5)
{
    if( number[0] == number[4] && number[1] == number[3])
        {
        Console.WriteLine(" Число является палиндромом");
        }
    else 
    {
    Console.WriteLine("Число не является палиндромом");
    }
}