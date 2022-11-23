/* Задача 10: Напишите программу, 
которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int userNumber = new int();
Console.WriteLine("Введи трехзначное число!");
userNumber = Convert.ToInt32(Console.ReadLine());
int result = 0;
result = (userNumber/10)% 10;
Console.WriteLine($"Второе число из числа {userNumber} будет {result} ");