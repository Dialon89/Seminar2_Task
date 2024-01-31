//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости,
// в которой находится эта точка.

Console.Clear();
Console.Write("Введите кординату точки Х: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите кординату точки Y: ");
int y = int.Parse(Console.ReadLine()!);

if (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
        Console.WriteLine("№ 1");
    else if (x < 0 && y > 0)
        Console.WriteLine("№ 2");
    else if (x < 0 && y < 0)
        Console.WriteLine("№ 3");
    else if (x > 0 && y < 0)
        Console.WriteLine("№ 4"); 
}
else {
    Console.WriteLine("Ошибка! Кординаты точек не должны быть равны нулю!");
}
