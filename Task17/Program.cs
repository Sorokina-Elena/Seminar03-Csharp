/* 
Задача 17
Напишите программу, которая принимает на вход координаты точки (X и Y),
причеи X не равно 0, и Y не равно 0, и выдает номер четверти плоскости,
в которой находится эта точка
*/

string data = "data";
string error = "error";
string result = "result";

void Print(string text, string arg)
{
    switch (arg)
    {
        case "data" : Console.ForegroundColor = ConsoleColor.Yellow;
        break;
        case "error" : Console.ForegroundColor = ConsoleColor.Red;
        break;
        case "result" : Console.ForegroundColor = ConsoleColor.Green;
        break;
    }
    Console.WriteLine(text);
}

int GetInNum()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return(number);
}




void FindQuarter(int x, int y)
{
    if (x == 0 || y == 0)
    {
        Print("Our or bouth coordinate equal 0", error);
    }
    else
    {
        switch ((x, y))
        {
            case(>0, >0) : Print("First quarter", result);
            break;
            case(>0, <0) : Print("Second quarter", result);
            break;
            case(<0, <0) : Print("Third quarter", result);
            break;
            case(<0, >0) : Print("Fourth quarter", result);
            break;
        }
    }
}



Print("Input X coordinate", data);
int coordinateX = GetInNum();

Print("Input Y coordinate", data);
int coordinateY = GetInNum();

//Print($"Our coordinates: X = {coordinateX}, Y = {coordinateY}", data);

FindQuarter(coordinateX, coordinateY);


