﻿using CSharpExercise.PrintHello;
using System;

namespace CSharpExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("題目:");
            Console.WriteLine("1. 輸入n 印出 Hello 圖型 第一版");
            Console.WriteLine("請選擇題目:");

            string whitchOne = Console.ReadLine();

            switch (whitchOne)
            {
                case "1":
                    Console.WriteLine("題目1 start ...");
                    Console.WriteLine("請輸入 n :");

                    int num1 = Convert.ToInt32(Console.ReadLine());
                    PrintHello1 printHello = new PrintHello1();
                    printHello.Main(num1);
                    break;
            }




            Console.ReadKey();
        }
    }
}