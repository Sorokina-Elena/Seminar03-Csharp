/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


int FindRandomNumber(int min, int max)
{
    int result = new Random().Next(min, max +1);
    return(result);
}

void Print(string text)
{
    Console.WriteLine(text);
}

int GetInNum()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return(number);
}

void FindСube(int number)
{
    for (int i = 1; i < number+1; i++)
    {
        Console.Write($"{Math.Pow(i,3)}, ");
    }

}

Print("Введите минимальное и максимальное число для создания диапозона");
int Min = GetInNum();
int Max = GetInNum();

int result = FindRandomNumber(Min, Max);

Print($"Случайное число - {result}");

FindСube(result);





