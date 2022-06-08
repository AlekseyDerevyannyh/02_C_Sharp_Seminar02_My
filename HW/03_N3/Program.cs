// Задача 3: Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет
using System;
using static System.Console;

Clear();
Write("Введите число: ");
int number = Convert.ToInt32(ReadLine());
if (Math.Abs(number) < 100) {
	Write("{0} -> ОШИБКА! Третьей цифры нет!", number);
	return;
}
int count = 0;
int number1 = number;
while (number1 != 0) {
	number1 /= 10;
	count ++;
}
Write("{0} -> {1}", number, (Math.Abs(number) / Convert.ToInt32(Math.Pow(10, (count - 3)))) % 10);