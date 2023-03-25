//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Write("Введите значение m : ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine());

int SumElems(int x, int y)
{
    if (x > y) return 0;
    else return x + SumElems(x + 1, y);
}

Console.WriteLine(SumElems(m,n));