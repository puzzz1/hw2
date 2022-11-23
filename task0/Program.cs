 /* Напишите программу, которая принимает на вход цифру, 
 обозначающую день недели, и 
 проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

int userNumber = new int();
Console.WriteLine("Введи номер дня недели");
userNumber = Convert.ToInt32(Console.ReadLine());
if 
    (userNumber < 5)
    Console.WriteLine("Рабочий!");

else
{Console.WriteLine("Выходной!");}

