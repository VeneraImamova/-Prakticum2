/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int randomNumber = new Random().Next(100, 10000);
System.Console.WriteLine(randomNumber);
string inputNumber = Convert.ToString(randomNumber);

if (inputNumber.Length < 3)  Console.Write("Третьей цифры нет");
else Console.Write($"Третья цифра числа {(inputNumber)} равна {(inputNumber[2])}" );