// Задача 4: Напишите программу, 
// которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

Console.Clear();
Console.Write("Введите натуральное число: ");
int n = int.Parse(Console.ReadLine()!);
string n2 = "";

while (n > 0)
{
    int n1 = n % 10;
    n2 += n1 + ", ";
    n /= 10;
}
Console.WriteLine(n2);
