﻿// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string [] array = {"Hello", "2", "world",":-)"};

foreach (string item in array)
{
    if (item.Length<=3)
    System.Console.Write(item+ ", ");
}