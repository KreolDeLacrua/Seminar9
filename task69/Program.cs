// Задача 69: Напишите программу, 
// которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите A ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите B ");
int numberB = Convert.ToInt32(Console.ReadLine());

int SqrAB(int a, int b)
{
    if (b == 0) return 1;
    else return SqrAB(a, b - 1) * a; 
}
int sum = SqrAB(numberA, numberB);
Console.WriteLine(sum);
