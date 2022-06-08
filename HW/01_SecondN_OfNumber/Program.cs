// Задача 1: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа
using System;
using static System.Console;

Clear();
Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(ReadLine());

if((Math.Abs(number) < 100) || (Math.Abs(number) > 999)) {
	Write("ОШИБКА! Число не трёхзначное!!!");
	return;
}
Write("{0} -> {1}", number, (number / 10) % 10);