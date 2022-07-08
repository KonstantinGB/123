/* 
//Task 1: определить является ли первое число квадратом второго
int num1, num2;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");
// Task 2

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}

 */


Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 7 || num < 1)
{
    Console.Write("Такого дня недели не существует");
}
else
{
    if ( num == 1) Console.Write("Понедельник");
    if ( num == 2) Console.Write("Вторник");
    if ( num == 3) Console.Write("Среда");
    if ( num == 4) Console.Write("Четверг");
    if ( num == 5) Console.Write("Пятница");
    if ( num == 6) Console.Write("Суббота");
    if ( num == 7) Console.Write("Воскресенье");
}


