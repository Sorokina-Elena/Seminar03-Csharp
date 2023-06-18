/*
Напишите программу, котороя на вход получает число N, 
и выдает таблицу квадратов чисел от 1 до N
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

void FindSquare(int number)
{
    for (int i = 1; i < number+1; i++)
    {
        Console.Write($"{Math.Pow(i,2)}, ");
    }

}

Print("Введите минимальное и максимальное число для создания диапозона");
int Min = GetInNum();
int Max = GetInNum();

int result = FindRandomNumber(Min, Max);

Print($"Случайное число - {result}");

FindSquare(result);

