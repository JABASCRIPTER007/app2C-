using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstnumber, secondnumber, thirdnumber, quarternumber, fivenumber, sixnumber, seventhnumber, eighthnumber, ninthnumber;


            Console.WriteLine("Введiть число 1");

            firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введiть число 2");
            secondnumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введiть число 3");
            thirdnumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введiть число 4");
            quarternumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введiть число 5");
            fivenumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введiть число 6");
            sixnumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введiть число 7");
            seventhnumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введiть число 8");
            eighthnumber = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Введiть число 9");
            ninthnumber = int.Parse(Console.ReadLine());
            Console.WriteLine();



            int result = (firstnumber + secondnumber + thirdnumber + quarternumber + fivenumber + sixnumber + seventhnumber + eighthnumber + ninthnumber) / 9;

            Console.WriteLine("Середнє арифметичне з дев'яти чисел = " + result);
            Console.WriteLine();

            int[] array = new int[9];

            array[0] = firstnumber;
            array[1] = secondnumber;
            array[2] = thirdnumber;
            array[3] = quarternumber;
            array[4] = fivenumber;
            array[5] = sixnumber;
            array[6] = seventhnumber;
            array[7] = eighthnumber;
            array[8] = ninthnumber;


            int[] myArray = { firstnumber, secondnumber, thirdnumber, quarternumber, fivenumber, sixnumber, seventhnumber, eighthnumber, ninthnumber };

            int minValue = myArray[0];

            for(int i = 1; i < myArray.Length; i++)
            {
                if(myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }
            }


            Console.WriteLine("Мiнiмальне значення дiапазону: " + minValue);
            Console.WriteLine();



            int maxValue = myArray[0];

            for (int i = 1; i < myArray.Length; i++)
            {
                if (myArray[i] > maxValue)
                {
                    maxValue = myArray[i];
                }
            }


            Console.WriteLine("Максимальне значення дiапазону: " + maxValue);
            Console.WriteLine();






            foreach (var el in array.OrderBy(x => x)) 
                
               Console.WriteLine("Числа в порядку зростання: " + el);
               Console.WriteLine();
               Console.WriteLine("!!!");
               Console.WriteLine("П'яте число в порядку зростання являється медiаною");
               Console.WriteLine();





















            Console.ReadLine();


        } 
    }
}
