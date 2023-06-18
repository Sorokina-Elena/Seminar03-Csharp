/*
Задача 18
Напишите программу, которая по заданному номеру четверти, показывает 
диапазон возможных координат точек в этой четверти (x и y).
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

void FindCoordinates(int num)
{
    if (num > 0 && num < 5)
    {
        switch (num){
            case 1: Print ("X > 0, Y > 0");
            break;
            case 2: Print ("X > 0, Y < 0");
            break;
            case 3: Print ("X < 0, Y < 0");
            break;
            case 4: Print ("X < 0, Y > 0");
            break;
        }
    }
    else
    {
        Print("Введите числов диваозоне от 1 до 4");
    }
}


Print("Input number of quarter ");
int quarter = GetInNum();

FindCoordinates(quarter);

