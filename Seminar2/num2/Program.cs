﻿/*Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98

Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет */

int number= new Random().Next(100,1000);
Console.WriteLine("Число: "+number);
int a = number / 100;
int b = number % 10;
Console.Write(a);
Console.WriteLine(b);