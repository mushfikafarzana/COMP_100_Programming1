using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Part_5
{
    class Program
    {
        static Random generator = new Random();
        static void Main(string[] args)
        {
            #region Question 1 Tester
            //int[] numbers = { 5, 12,  8,  5,  7,  3,  5,  6,  9, 10, 16,  8, 11, 34,  9, 50, 12, 14, 45 };
            //DisplayIntArray (numbers);
            //Console.WriteLine();
            #endregion
            #region Question 2 Tester
            //int[] result = GenerateRandomIntArray(15, 10);
            //DisplayIntArray(result);
            //Console.WriteLine();
            //result = GenerateRandomIntArray(15, 10);
            //DisplayIntArray(result);
            //Console.WriteLine();
            //result = GenerateRandomIntArray(15, 10);
            //DisplayIntArray(result);
            #endregion
            #region Question 3 Tester
            //int[] intArray = GenerateRandomIntArray(20,100);
            //Console.WriteLine();
            //DisplayIntArray(intArray);
            //int[] evenOdd = CountEvenOdd(intArray);
            //Console.WriteLine();
            //DisplayIntArray(evenOdd);
            #endregion
            #region Question 4 Tester
            //int[] intArray = GenerateRandomIntArray(20, 10);
            //Console.WriteLine();
            //DisplayIntArray(intArray);
            //int[] result = CalculateDigitFrequencies(intArray);
            //Console.WriteLine();
            //DisplayIntArray(result);
            #endregion
            #region Question 5 Tester
            //int[] intArray = GenerateRandomIntArray(20, 100);
            //Console.WriteLine();
            //DisplayIntArray(intArray);
            //int[] result = CalculateLastDigitFrequencies(intArray);
            //Console.WriteLine();
            //DisplayIntArray(result);
            #endregion
            #region Question 6 Tester
            int[] intArray = GenerateRandomIntArray(20, 99);
            DisplayIntArray(intArray);
            Console.WriteLine();
            int[] result = CalculateNumberFrequencies(intArray);
            DisplayIntArray(result);
            Console.WriteLine();
            #endregion
            #region Question 7 Tester

            string someString = "THEQUICKBROWNFOXJUMPSOVERTHELAZYDOG";
            Console.WriteLine(someString);
            int[] count = new int[26];
            count = CountLetters(someString);
            foreach (int value in count)
            {
                Console.Write($" {value} ");
            }
            #endregion
            #region Question 8 Tester
            //Console.WriteLine($"{Decimal2Binary(11)}");
            #endregion
            #region Question 9 Tester

            #endregion
            #region Question 10 Tester
            //generateFibo(10);
            #endregion
            #region Question 11 Tester
            //Console.WriteLine(factorialRecursion(6));
            //Console.WriteLine(factorialNormal(6));
            #endregion
            #region Question 12 Tester
            //double p1 = 0.0100000000, p2 = 0.0004000000, p3 = 0.0000160000, p4 = 0.0000006400, p5 = 0.0000000256;
            //ComputePI(p1);
            //ComputePI(p2);
            //ComputePI(p3);
            //ComputePI(p4);
            //ComputePI(p5);
            #endregion
            #region Question 13 Tester
            //Console.WriteLine(Gcd(27,18));
            #endregion
            #region Question 14 Tester

            #endregion
        }
        #region Question 1
        /*
         * 1.	Write a method with header static void DisplayIntArray(int[] numbers). The first argument is an array of ints.
         * There is no return value. This method displays all the elements of the argument on a single line. Each item will
         * occupy three columns. Call this method from main with a suitable argument
         */
        static void DisplayIntArray(int[] numbers)
        {
            int counter = 0;
            while (counter < numbers.Length)
            {
                Console.Write($"{numbers[counter], 3}");
                counter++;
            }
        }
        #endregion
        #region Question 2
        /*
         * 2.	Write a method with header static int[] GenerateRandomIntArray(int numberOfItems, int largestValue). 
         * The first argument is an int indicating the number of elements that will be present in the return array. 
         * The second argument is an int representing the largest item in the array. The returned value is an array of integers.
         * This method does the following:
         * a.	Declare and initialized a variable of type Random (Random generator = new Random();)
         * b.	Declare an array of type int (you may call it result)
         * c.	Allocate storage for the correct number of items
         * d.	Using your favorite looping statement, assign a random integer to each element of the array (result[i] = generator.Next(largestValue);)
         * In your main method, call the above method three times with arguments 15, 10 and 25, 10 and 30, 100. 
         * In each case assignment the results to a suitable variable and use the DisplayIntArray() method to display the value.
         */
        static int[] GenerateRandomIntArray(int numberOfItems, int largestValue)
        {
            int[] result = new int[numberOfItems];
            for (int i = 0; i < numberOfItems; i++)
            {
                result[i] = generator.Next(largestValue);
            }
            return result;
        }
        #endregion
        #region Question 3
        /*
         * 3.	Write a method with header static int[] CountEvenOdd(int[] array). The argument is an int array. The returned value
         * is an array of 2 integers. The elements of the return array will be a count of the odd and even items in the argument.
         * The first element of the returned array represents the number of odds in the argument and the second element indicates
         * the number of evens in the argument. The method will create an int array of 2 elements (call this the result). 
         * In your main method, call the GenerateRandomIntArray() method to create an int array using and assign it to a suitable 
         * variable. Using the DisplayIntArray() method display all the item of the return. 
         * Call the CountEvenOdd() method passing the above array as an argument and display the return value. 
         * Do a count to verify that your method is working correctly.
         */
        static int[] CountEvenOdd(int[] array)
        {
            int[] result = new int[2];
            int countOdd = 0;
            int countEven = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)

                    countEven++;
                else
                    countOdd++;
            }
            result[0] = countOdd;
            result[1] = countEven;
            return result;
        }
        #endregion
        #region Question 4
        /*
         * 4.	Write a method with header static int[] CalculateDigitFrequencies(int[] array). The argument is an int array 
         * with values ranging from 0 to 9. The returned value is an array of 10 integers. The elements of the return array will be
         * a count of the frequencies of the items in the argument. The first element of the returned array represents the number 
         * of 0’s in the argument, the second element indicates the number of 1’s in the argument and the third element will indicate
         * the number of 2’s in the argument. The method will create an int array of 10 elements (call this the result). Each item
         * of the argument is examined and the appropriate element of the result array is incremented. In your main method, create 
         * an int array using the GenerateRandomIntArray() method remember to use 10 as the second argument to the method and then
         * print out the elements using the DisplayIntArray() method. Call the above method and display the return value. 
         * Do a count to verify that your method is working correctly.
         */
        #endregion
        static int[] CalculateDigitFrequencies(int[] array)
        {
            int[] result = new int[10];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        if (j == array[i])
            //        {
            //            result[j]++;
            //        }
            //    }
            //}

            foreach (int item in array)
            {
                result[item]++;
            }
            return result;
        }
        #region Question 5
        /*
         * 5.	Write a method with header static int[] CalculateLastDigitFrequencies(int[] array). The argument is an int array.
         * The returned value is an array of 10 integers. The elements of the return array will be a count of the frequencies of
         * the items in the argument. The first element of the returned array represents the number with last digit of 0’s in the
         * argument, the second element indicates the number with last digit of 1’s in the argument and the third element will 
         * indicate the number with last digit of 2’s in the argument. The method will create an int array of 10 elements 
         * (call this the result). Each item of the argument is examined and the appropriate element of the result array is 
         * incremented.  In your main method, create an int array using the GenerateRandomIntArray() method and then print out 
         * the elements using the DisplayIntArray() method. Call the above method and display the return value. 
         * Do a count to verify that your method is working correctly.
         */
        #endregion
        static int[] CalculateLastDigitFrequencies(int[] array)
        {
            int[] result = new int[10];
            foreach (int item in array)
            {
                result[item % 10]++;
            }
            return result;   
        }
        #region Question 6
        /*
         * 6.	Write a method with header static int[] CalculateNumberFrequencies(int[] array). The argument is an int array 
         * with values ranging from 0 to 99. The returned value is an array of 10 integers. The first element will indicate the 
         * number or unit values in the argument (i.e. values 0-9), the second element will indicate the number of 10 values 
         * (i.e. values 10-19), the third element will indicate the number of 20 values (i.e. values 20-29) etc. The method will 
         * create an int array of 10 elements (call this the result). Each item of the argument is examined and the appropriate 
         * element of the result array is incremented. In your main method, create an int array using the GenerateRandomIntArray()
         * method and then print out the elements using the DisplayIntArray() method. Call the above method and display 
         * the return value. Do a count to verify that your method is working correctly
         */
        static int[] CalculateNumberFrequencies(int[] array)
        {
            int[] result = new int[10];
            //for (int i = 0; i < array.Length; i++)
            //{
            //            result[array[i] / 10]++;
            //}
            foreach (int item in array)
            {
                result[item / 10]++;
            }
            return result;
        }
        #endregion
        #region Question 7
        /*
         * 7.	Write a method that takes a string and return a distribution of the letter in the string. A distribution 
         * can be an array of the letter frequencies. To simplify code, you may assume that all the letters will be 
         * lowercased (or uppercased) and there are no periods or spaces. Call the above method and display the return value
         * Do a count to verify that your method is working correctly.
         */
        static int[] CountLetters(string someString)
        {
            int[] count = new int[26];
            char[] charArray = someString.ToCharArray();
            for (int i = 65; i <= 90; i++)
            {
                for (int j = 0; j < someString.Length; j++)
                {
                    if (charArray[j] == i)
                    {
                        count[i - 65]++;
                    }
                }
            }

            return count;
        }
        #endregion

        #region Question 8
        /*
         * 8.	Write a method that returns a binary string representation of its argument. Call this method from your main 
         * and display the returned values. If you call the method three times with the integers 7, 128 and 15 respectively
         * the method will return the binary strings 111, 10000000 and 1111 respectively
         */
        static string Decimal2Binary(int num)
        {
            int rem = 0;
            string remStr = "";

            do
            {
                rem = (num % 2);
                remStr = rem.ToString() + remStr;

            } while ((num /= 2) >= 2);
            //rem += num;
            remStr = num.ToString() + remStr;
            return remStr;
        }
        #endregion
        #region Question 9
        /*
         * 9.	Write a method that will return the year-end balance for a mortgage, given the beginning balance, the yearly 
         * interest rate, and the bi-weekly payments. You can assume that there are 26 payments in the year and the mortgage
         * is re-calculated after each payment. For each period, you will need to calculate the interest (you will need to 
         * calculate the daily interest and times it by the number of days in each period), then add this to the starting balance
         * and then subtract the payment. If the starting principal is $300,000, the interest rate is 2.5% and the bi-weekly payment
         * is $1,000, what will be the year-end balance? How much would you save if you increased the monthly payment by $100?
         */

        #endregion
        #region Question 10
        /*
         * 10.	Write a method that will display the nth term of a Fibonacci sequence. The nth term is defined as the sum of the
         * two previous terms. The first few terms of the Fibonacci series are 1, 1, 2, 3, 5, 8, 13, 21, etc.
         */
        static void generateFibo(int term)
        {
            int n1 = 1, n2 = 1, count = 0;
            Console.WriteLine($"{n1}");
            while (count <= term - 2)
            {
                int temp;
                Console.WriteLine($"{n2}");
                temp = n1 + n2;
                n1 = n2;
                n2 = temp;
                count++;
            }
        }
        #endregion
        #region Question 11
        /*
         * 11.	Write a method that will return the factorial of its argument number. [n! = n(n-1)(n-2)(n-3)… (1)] 
         */
        //static int factorialRecursion(int num)
        //{
            //        if (num >= 1)
            //        {
            //            return num* factorialRecursion(num - 1);
            //}
            //        else
            //        {
            //            return 1;
            //        }
            //    }

            //Alternative way
            //static int factorialNormal(int num)
            //{
            //    int fac = 1;
            //    while (num >= 1)
            //    {
            //        fac *= num;
            //        num--;
            //    }
            //    return fac;
            //}
        //}
            #endregion

            #region Question 12
            /*	
             *	12. Write a method that computes the value of PI given by the expression π/4=1-1/3+1/5-1/7+1/9-1/11⋯.
             *	How many terms are needed to match Math.PI?
             */
            static void ComputePI(double precision)
            {
                int sign = 1;
                double deno = 1.00;
                double pye = 0.00;
                int count = 0;
                do
                {
                    pye += sign * (4 / deno);
                    deno += 2;
                    sign *= -1;
                    count++;
                    //Console.WriteLine($"sign={sign} deno={deno} count={count} pye={pye} diff={Math.PI - pye}");

                } while (Math.Abs(Math.PI - pye) > precision);

                Console.WriteLine($"It will take {count} terms to achieve a precision of {precision} and pi={pye}");
            }
        #endregion
        #region Question 13
        /*
         * 13.	Write a method that takes two integers and returns the greatest common divisor (gcd).
         */
        static int Gcd(int a, int b)
        {
            if (a == 0) return b;
            if (b == 0) return a;
            if (a == b) return a;
            if (a > b) return Gcd(a - b, b); else return Gcd(a, b - a);
        }
        #endregion
        #region Question 14
        /*
         * 14.	Write a method similar to question 3, that counts the distribution of two-letters combinations i.e. digrams
         */

        #endregion
    }
}
