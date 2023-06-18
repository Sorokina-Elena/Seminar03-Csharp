/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом:

14212 -> нет
12821 -> да
23432 -> да
*/

void Print(string text)
{
    Console.WriteLine(text);
}

int GetInNum()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return(number);
}

int FindTrue(int number)
{
    if ((number / 10000) == (number % 10) && ((number / 1000) %10) == (number %100/10))
    {
        Print("Число является палиндромом");
    }
    else
    {
        Print("Число не является палиндромом");
    }
    return(number);
}

Print("Введите 5-ти значное число");
int number = GetInNum();
int result = FindTrue(number);

