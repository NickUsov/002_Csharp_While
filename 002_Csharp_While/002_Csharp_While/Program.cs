using System;
using static System.Console;

namespace _002_Csharp_While
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ввести с клавиатуры номер трамвайного билета(6-значное число) и проерить является ли данный билет счастливым(если на билете 
            //напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым)

            int num, count = 0, sumL = 0, sumR = 0;
            Console.WriteLine("Введите шестизначный номер билета");
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {

                if (count < 3)
                    sumR += num % 10;
                else
                    sumL += num % 10;
                num /= 10;
                count++;
            }
            if (count == 6)
            {
                if (sumL == sumR)
                    Console.WriteLine("Билет счастливый!");
                else
                    Console.WriteLine("Билет не счастливый");
            }
            else
                Console.WriteLine("В номере не 6 цифр");

            //2. Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. Например, если было введено 
            //число 345, то программа должна вывести число 543.

            int result = 0;
            WriteLine("Enter integer");
            int number = int.Parse(ReadLine());
            while (number > 0)
            {

                result += number % 10;
                number /= 10;
                if (number > 0)
                    result *= 10;
            }
            WriteLine(result);
        }
    }
}
