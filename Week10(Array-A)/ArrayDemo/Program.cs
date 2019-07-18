using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {

        static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        static int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };
        static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        static string[] poem = { "Mary", "had", "a", "little", "lamb" };
        static string[] obama = { "Barack", "Hussein", "Obama" };

        static void Main(string[] args)
        {
            //PrintStringArray();
            //PrintPoem();
            //SumPrimes();
            //DoublePrimes();
            //SumPrimes();
            //PrintVowel();
            //VowelSubtraction();
            //PrintVowel();
            //Console.WriteLine(SumOfPrimes());
            //DisplayPrimes();
            DisplayNumbers();
        }
        #region Question 1
        /*
         * 1.	Write a method that prints the string array obama. 
         * Each element must be on a separate line.
         * From your main, call this method. [Your method will not
         * take any parameters and it does not return a value.]
         
        */

        static void PrintStringArray()
        {
            int position = 0;
            do
            {
                Console.WriteLine(obama[position]);
                position++;
            } while (position < obama.Length);
        }
        #endregion
       
        #region Question 2
        /*
         * 2.	Write a method that prints the string array poem in reverse order. 
         * All the items must be in the same line. Your method will not take any 
         * parameters and it does not return a value.
         * From your main, call this method. 
         */

        static void PrintPoem()
        {
            int position = poem.Length;
            while (position > 0)
            {
                position--;
                Console.Write($"{poem[position]} ");
            }
            Console.WriteLine();

            //int position = poem.Length - 1;
            //while (position >= 0)
            //{
            //    Console.Write($"{poem[position]} ");
            //    position--;
            //}
            //Console.WriteLine();
        }
        #endregion

        #region Question 3
        /*
         * 3.	Write a method that sums all the items of the array primes, 
         * and then display this sum. From your main, call this method. 
         * [Your method will not take any parameters and it does not return a value.]
         */
        static void SumPrimes()
        {
            //int sum = 0;
            //for (int counter = 0; counter < primes.Length; counter++)
            //{
            //    sum += primes[counter];
            //}
            //Console.WriteLine($"Sum is {sum}");

            int counter = 0, sum = 0;
            do
            {
                sum += primes[counter];
                counter++;
            } while (counter < primes.Length);
            Console.WriteLine($"Sum is {sum}");
        }
        #endregion

        #region Question 4
        /*
         * 4.	Write a method that doubles all the items of the int array primes.
         * This method does not display anything. From your main, call the previous method,
         * this method and then the previous method again. Because the previous method was
         * called twice, you will have two printouts, one with the original value and the second one
         * with the doubled values. [Your method will not take any parameters and it does not return a value.]
         */
         static void DoublePrimes()
         {
            for (int counter = 0; counter < primes.Length; counter++)
            {
              primes[counter] *= 2;
            }

         }
        #endregion

        #region Question 5
        /*
         * 5. A) Write a method that will subtract 32 from each item of the char array vowels. 
         * The result of any arithmetic operation is a number, so you will have to cast your result
         * to a char in order to assign the resulting value to the char array 
         * B) Write a second method that will display all the items of the char array vowels on a single line 
         * C) From your main, call the second method, then the first and then the second again
         * Subtracting or adding 32 is a common technique for converting from lower case alphabet
         * to upper case alphabet and vice-versa
         */
         static void VowelSubtraction()
         {
            int position = 0;
            while (position < vowels.Length)
            {
                vowels[position] = (char)(vowels[position] - 32);
                position++;
            }
         }
        static void PrintVowel()
        {
            int position = 0;
            while (position < vowels.Length)
            {
                Console.Write($"{vowels[position]} ");
                position++;
            }
            Console.WriteLine();
        }
        #endregion

        #region Question 6
        /*
         * 6.	Modify your solution for Question 3 so that the method calculates the sum, 
         * but return this value instead of displaying it
         * From your main, call this new method and display the return value
         */
         static int SumOfPrimes()
         {
            int counter = 0, sum = 0;
            do
            {
                sum += primes[counter];
                counter++;
            } while (counter < primes.Length);
            return sum;
        }
        #endregion

        #region Question 7
        /*
         * 7.	Write a method that displays on the items that are greater than 10 in the primes array. 
         * Your method will not take any parameters and it does not return a value.
         * From your main, call this method. 
         */
         static void DisplayPrimes()
         {
            for (int position = 0; position < primes.Length; position++)
            {
                if (primes[position] > 10)
                {
                    Console.Write($"{primes[position]} ");
                }
            }
         }
        #endregion

        #region Question 8
        /*
         * 8.	Write a method that display the number of even and odd items in the numbers array. 
         * Your method will not take any parameters and it does not return a value.
         * From your main, call this method.
        */
        static void DisplayNumbers()
        {
            int even = 0, odd = 0;

            for (int position= 0; position < numbers.Length; position++)
            {
                if (numbers[position] % 2 == 0)

                    even++;
                else
                    odd++;
            }
            Console.WriteLine($"Number of even items is {even} and odd items is {odd} ");
        }
        #endregion
    }
}