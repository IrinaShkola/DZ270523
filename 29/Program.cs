﻿//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int [] arr = new int [8];
Random rand = new Random(); 
int a = 8;
for(int i = 0; i< arr.Length; i++)
{
arr[i] = rand.Next( 10);
}
Console.WriteLine('[' + string.Join(", ", arr) + ']');
