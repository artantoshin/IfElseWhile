// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

int num1 = 8;
int num2 = 6;
//Encoding cp1251 = Encoding.GetEncoding(1251);
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

//Циклы

for (int i = 1; i < 4; i++)
{
    Console.WriteLine(i);
}

int i2 = 6;
do
{
    Console.WriteLine(i2);
    i2--;
}
while (i2 > 0);

int i3 = 6;
while (i3 > 0)
{
    Console.WriteLine(i3);
    i3--;
}

foreach (char c in "Tom")
{
    Console.WriteLine(c);
}
//Выход из цикла
for (int i = 0; i < 9; i++)
{
    if (i == 5)
        break;
    Console.WriteLine(i);
}

//Выход из итерации
for (int i = 0; i < 9; i++)
{
    if (i == 5)
        continue;
    Console.WriteLine(i);
}
