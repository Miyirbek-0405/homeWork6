
// =============================== start ===========================================

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4

/*
Console.Write("Введите граница счетчика: ");
int number = Convert.ToInt32(Console.ReadLine());
void PrintCout(int number)
{
    int cout = 0;
    for (int i = 0; i < number; i++)
    {
        Console.Write("Введите любое число: ");
        int anyNumber = Convert.ToInt32(Console.ReadLine());
        if (anyNumber > 0)
        {
            cout++;
        }
    }
    Console.WriteLine($"числы которые больше нуля {cout}");
}
PrintCout(number);
*/


// это второй вариант постарался  
/*
void WhileStop(){
    int cout = 0;
    while(true){
        Console.Write("Введите любое число: ");
        int anyNumber =Convert.ToInt32(Console.ReadLine());
        Console.Write("Хотите закончить? ");
        string? magicWord =Console.ReadLine();
        if(anyNumber > 0)
        {
            cout++;
        }
        if(magicWord=="no"){
            continue;
        }
        if(magicWord=="yes" || magicWord==""){
            break;
        };
    }
    Console.WriteLine($"числы которые больше нуля {cout}");
}

WhileStop();
*/

// =============================== end ===========================================

// =============================== start ===========================================

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Dведите число b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Dведите число k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Dведите число b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Dведите число k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

void PointOfIntersectionOfTwoLines(double b1, double k1, double b2, double k2)
{
    double x = Math.Round(((b2 - b1) / (k1 - k2)), 1);
    double y = Math.Round((k1 * x + b1), 1);
    if (k1 == k2)
    {
        Console.WriteLine("прямые не пересекаются");
    }
    Console.WriteLine($"x={x}, y={y} ");
}

PointOfIntersectionOfTwoLines(b1, k1, b2, k2);

// =============================== end ===========================================