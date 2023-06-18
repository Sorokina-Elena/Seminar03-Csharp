/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
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

double FindDistance(int x1, int y1, int x2, int y2)
{
    double result = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
    return(result);
}



Print("Insert X1, Y1, X2, Y2");
int x1 = GetInNum();
int y1 = GetInNum();
int x2 = GetInNum();
int y2 = GetInNum();

double result = FindDistance(x1, y1, x2, y2);
Print($"Distance between points is {result}");

