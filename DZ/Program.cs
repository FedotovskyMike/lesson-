﻿/* Задача 2: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

/* 

int max = 0;
int min = 0;

int a = int.Parse(Console.ReadLine());//Перервод строки, преобразование строки в int числовые значения.
int b = int.Parse(Console.ReadLine());//Перервод строки, преобразование строки в int числовые значения.

if (a > b)
{
    max = a;
    min = b;
} 
if (a < b)
{
    max = b;
    min = a;
} 

 Console.WriteLine("Наибольшое число: ");
  Console.WriteLine(max);
 Console.WriteLine("Наименьшее число: ");
  Console.WriteLine(min); 


/*  Задача 4: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

/* int max = 0;//максимальное значение


int a = int.Parse(Console.ReadLine());//Перервод строки, преобразование строки в int числовые значения.
int b = int.Parse(Console.ReadLine());//Перервод строки, преобразование строки в int числовые значения.
int c = int.Parse(Console.ReadLine());//Перервод строки, преобразование строки в int числовые значения.


if (a > b && a > c)//&& две аперсанты обозначают лог И(выполняется два условия)
{
    max = a;
}   
if (b > a && b > c)//&& две аперсанты обозначают лог И(выполняется два условия)
{
    max = b;
} 
if (c > a && c > b)//&& две аперсанты обозначают лог И(выполняется два условия)
{
    max = c;
}

 Console.WriteLine("Наибольшое число: ");//вывод строки
  Console.WriteLine(max);//вывод строки */


/* Задача 6: Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным
(делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

/* double b = 0.0;
int a = int.Parse(Console.ReadLine());

double x = a % 2; 

if (x == 0)//оператор if проверяет остаток от деления на 2
{ 
    Console.WriteLine("Число является чётным и делится без остатка на 2");
} 

 else //оператор else выводит строку если число не чётное
{
    Console.WriteLine("Число нечётное");
} */

/* Задача 8: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

/* int count = 2;
int n = int.Parse(Console.ReadLine());

while (count <= n)// цикл сравнивает счётчик count с введённым числом. Цикл будет работать пока каут меньше или равен введёному числу.
{
    Console.WriteLine(count);//Выводятся чётные числа.
    count += 2;// к счётчику прибавляется +2.
}
 */

// СЕМИНАР УРОК 2.

/* Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

/* Console.WriteLine("Введите трехзначное число.\nВыхода из программы команда q.");
    while(true)
{
string input = Console.ReadLine();
if(!input.Equals("q"))
Console.WriteLine("{0}->{1}",input, input[1]);
else
break;
} */

/* Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */


/* Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
  {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

CheckingTheDayOfTheWeek(dayNumber); */

