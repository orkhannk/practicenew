using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sum(10, 15, 20));
            Console.WriteLine(sum(10.5, 12.3, 20.4));
            Console.WriteLine(Sum(new int[] { 3, 4, 6 }));
            Console.WriteLine(Sum(new double[] { 3.4, 5.5, 6.6 }));
            Console.WriteLine(FindFirstIndex("Salam", 'S'));
            Console.WriteLine(FindLastIndex("Sagol brat", 'a'));
            Console.WriteLine(FindBiggestNum(new int[] { 3, 4, 6, 9, 10, 8, 17 }));
            Console.WriteLine(Check(16));
            Console.WriteLine(Count(new int[] { 16, 17, 19, 22, 24, 23, }));
            Console.WriteLine(Array2(new int[] { 1, 3, 5, 6, 8, }  ) ) ;
            Console.WriteLine(RemoveLeftSpace(" salam "));
            Console.WriteLine(RemoveLastSpace("salam  "));
        }
        //Verilmiş 3 ədədin cəmini tapan method (həm int, həm double ədədlər üçün)

        static int sum(int num1, int num2, int num3 = 0)
        {
            return num1 + num2 + num3;
        }
        static double sum(double num1, double num2, double num3 = 0)
        {
            return num1 + num2 + num3;
        }



        //Verilmiş ədədlər siyahısındaki bütün ədədlərin cəmini tapan method (həm int, həm double ədədlər üçün)

        static int Sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        static double Sum(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }


        //Verilmiş yazıda veirlmiş charın yerləşdiyi ilk indexi tapan method (yoxdursa -1 qaytarı)

        static int FindFirstIndex(string text, char wantedChar)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == wantedChar) return i;
            }
            return -1;
        }


        //Verilmiş yazıda veirlmiş charın yerləşdiyi son indexi tapan method (yoxdursa -1 qaytarı)

        static int FindLastIndex(string text, char wantedChar)
        {
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (text[i] == wantedChar) return i;

            }
            return -1;
        }


        //Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan method

        static int FindBiggestNum(int[] array)
        {
            int biggestnum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > biggestnum)
                {
                    biggestnum = array[i];
                }
            }
            return biggestnum;

        }


        //Verilmiş ədədin müsbət və cüt olub olmadığını tapan method
        static bool Check(int number)
        {
            if (number > 0 && number % 2 == 0)
                return true;
            else
                return false;
        }


        //Verilmiş ədədlər siyahısındaki müsbət və cüt ədədlərin sayını tapan method

        static int Count(int[] array1)
        {
            int count = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] > 0 && array1[i] % 2 == 0)
                {
                    count++;

                }
            }
            return count;
        }


        //Verilmiş ədədlər siyahısındaki müsbət və cüt ədədlərdən ibarət yeni bir array düzəldən method.

        static int Array2(int[] numbers )
        {
            int length = numbers.Length;
            int[] numbers1 = new int[length];
            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers1[i] = numbers[i];
            }
            int sum = 0;
            for(int i = 0; i < numbers1.Length; i++)
            {
                if (numbers[i]>0 && numbers[i] % 2 == 0)
                {
                    sum++;
                }
                
               
            }
            int index = 0;
            int[] positivenumbers = new  int [sum];
            for(int i = 0; i < numbers1.Length; i++)
            {
                if (numbers[i] > 0 && numbers[i] % 2 == 0)
                {
                    positivenumbers[index] = numbers[i];
                    index++;
                }

            }
            return index;
        }


        //Verilmiş ədədlər siyahısından tərsinə düzülmüz yeni bir array qaytaran method. 

       // static int GetReversedArray(int[] numbers)
        //{
           // int[]  reversedArray = new int[numbers.Length];
           //for (int i = 0; i < numbers.Length ; i++)
           //{
                //reversedArray[i] = numbers[numbers.Length - 1 - i];
           // }
           // return reversedArray;
        //}


        //Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən method
        static string RemoveLeftSpace(string text)
        {

            string newText = "";
            int startIndex = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    startIndex = i;
                    break;
                }
            }
            for (int i = startIndex; i < text.Length; i++)
            {
                newText += text[i];
            }
            return newText;
        }


        //Verilmiş yazıdan sonundaki boşluqlar silinmiş yeni string düzəldən method
        static string RemoveLastSpace(string text)
        {
            string newText = "";
            int lastIndex = text.Length - 1;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                if (text[i] != ' ')
                {
                    lastIndex = i;
                    break;
                }
            }
            for (int i = 0; i <= lastIndex; i++)
            {
                newText += text[i];
            }
            return newText;
        }

    }
}
