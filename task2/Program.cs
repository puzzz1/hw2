/* Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
int [] numbers;
numbers = new int [999999];
Console.WriteLine("Введи число!");
numbers[] = Convert.ToInt32(Console.ReadLine());
int result = numbers[2];
/* if 
    (numbers[2] = 0)
    Console.WriteLine("Нет второго числа!"); 
else 
{Console.WriteLine($"Второе число {result}");}*/

Console.WriteLine($"Второе число {result}");
