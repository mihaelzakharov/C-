// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.


Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne > numberTwo)
{
    Console.WriteLine("Первое число " + numberOne + " > " + "второго числа " + numberTwo);
}
else if (numberTwo > numberOne)
{
    Console.WriteLine("Первое число " + numberOne + " < " + "второго числа " + numberTwo);
}
else
{
    Console.WriteLine("Первое число " + numberOne + " = " + "второму числу " + numberTwo);
}



// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}
Console.WriteLine("Максимальное из этих трех чисел " + max); 


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Число " + num + " является: ЧЁТНЫМ");
}
else
{
    Console.WriteLine("Число " + num + " является: НЕЧЁТНЫМ");
}



// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

int i = 1;
bool not = true;

Console.Write("Введите число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write("Чётные числа от 1 до " + numberN + ": ");
while (i <= numberN)
{
    if (i % 2 == 0)
{
Console.Write(i + " ");
not = false;
}
i++;
}
if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}
Console.WriteLine();
