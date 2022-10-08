// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

int num1 = 8;
int num2 = 6;
Encoding cp1251 = Encoding.GetEncoding(1251);
if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"Число {num1} меньше числа {num2}");
}
else
{
    Console.WriteLine("Число num1 равно числу num2");
}

int x = 3;
int y = 2;

int z = x < y ? (x + y) : (x - y);
Console.WriteLine(z);   // 1