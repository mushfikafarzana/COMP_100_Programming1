using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Part_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 Tester
            //int var_x1 = 5;
            //Console.Write($"Before method call: {var_x1} ");
            //DoubleIt(ref var_x1);
            //Console.WriteLine($"After method call: {var_x1}");

            //int var_x2 = 7;
            //Console.Write($"Before method call: {var_x2} ");
            //DoubleIt(ref var_x2);
            //Console.WriteLine($"After method call: {var_x2}");
            #endregion
            #region Question 2 Tester
            //int value1 = 5;
            //Console.Write($"Before method call: {value1} ");
            //CubeIt(value1, ref value1);
            //Console.WriteLine($"After method call: {value1}");

            //int value2 = 7;
            //Console.Write($"Before method call: {value2} ");
            //CubeIt(value2, ref value2);
            //Console.WriteLine($"After method call: {value2}");
            #endregion
            #region Question 3 Tester
            int numberOfCourses = 5;
            double costPerCourse = 500;
            double fees = 0;
            CalculateTuitionFee(numberOfCourses, costPerCourse, ref fees);
            Console.WriteLine($"{numberOfCourses} courses @{costPerCourse :C} will cost {fees :C}");

            numberOfCourses = 5;
            costPerCourse = 450;
            CalculateTuitionFee(numberOfCourses, costPerCourse, ref fees);
            Console.WriteLine($"{numberOfCourses} courses @{costPerCourse:C} will cost {fees:C}");

            numberOfCourses = 10;
            costPerCourse = 450;
            CalculateTuitionFee(numberOfCourses, costPerCourse, ref fees);
            Console.WriteLine($"{numberOfCourses} courses @{costPerCourse:C} will cost {fees:C}");

            numberOfCourses = 10;
            costPerCourse = 350;
            CalculateTuitionFee(numberOfCourses, costPerCourse, ref fees);
            Console.WriteLine($"{numberOfCourses} courses @{costPerCourse:C} will cost {fees:C}");
            #endregion
            #region Question 4 Tester
            int a = 10, b = 15;
            int sum, difference;
            CalculationOfIntegers(a, b, out sum, out difference);
            Console.WriteLine($"a: {a}, b: {b}, sum: {sum} difference: {difference}");

            a = 25; b = 15;
            CalculationOfIntegers(a, b, out sum, out difference);
            Console.WriteLine($"a: {a}, b: {b}, sum: {sum} difference: {difference}");

            a = 25; b = 25;
            CalculationOfIntegers(a, b, out sum, out difference);
            Console.WriteLine($"a: {a}, b: {b}, sum: {sum} difference: {difference}");
            #endregion
            #region Question 5 Tester
            //int angle = 0;
            //Console.WriteLine(" Angle    Sine    Cosine   Tangent  ");
            //for (int i = 1; i < 20; i ++)
            //{
            //    CalculateTrigValues(angle, out double sine, out double cosine, out double tangent);
            //    Console.WriteLine($"{angle,6:F2} {sine,8 :f4} {cosine,8 :f4} {tangent,8 :f4}");
            //    angle += 5;
            //}
            #endregion
            #region Question 6 Tester
            double angle = 0.5;

            Console.WriteLine(" Angle    Sine    Cosine");
            for (int i = 1; i <= 10; i++)
            {
                CalculateTrigValues(angle, out double sine, out double cosine);
                Console.WriteLine($"{angle,5 :F2} {sine,9 :f4} {cosine,8 :f4}");
                angle += 0.01;
            }
            #endregion
            #region Question 7 Tester
            //double a = 12;
            //double b = 1;
            //double c = - 6;
            //CalculateQuadraticEquation(a, b, c, out double solution1, out double solution2);
            //Console.WriteLine($"Equation {a}x^2 + {b}x + {c} will have roots {solution1 :f3} and {solution2 :f3}");
            #endregion
        }
        #region Question 1
        /*
         * 1. Write a method call DoubleIt(ref int x) that takes a single argument and does not return a value.
         * This method will double the value of its argument. In your main, call this method twice and print
         * the value of the parameter after the method call
         */
        static void DoubleIt(ref int x)
         {
            x *= 2;
         }
        #endregion
        #region Question 2
        /*
         * 2.	Write a method call CubeIt(int x, ref int cube) that takes two arguments and does not return a value.
         * The method will cube the first argument and assign it to the second argument. 
         * In your main, call this method twice and print the value of the parameters after each method call.
         */
         static void CubeIt(int x, ref int cube)
         {
           cube = x * x * x;
         }
        #endregion
        #region Question 3
        /*
         * 3.	Write a method with the following header: static void CalculateTuitionFee(int numberOfCourses,
         * double costPerCourse, ref double fees). This method will calculate and assign the required fees amount
         * to the third argument. [Fees = number of courses * cost per course + 15.25]. From your program Main() method,
         * call the CalculateTuitionFee () method four times supplying different arguments each time and display the
         * value of the third argument after each method call.
         */
        static void CalculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees)
        {
            const double VALUE = 15.25;
            fees = numberOfCourses * costPerCourse + VALUE;
        }
        #endregion
        #region Question 4
        /*
         * 4.	Write a method that takes four parameter of type int. The method will assign the sum of the first
         * two arguments to the third and the difference of the first two to the fourth. This method should be 
         * coded so that the calling method will able to modify the values of the third and fourth parameters.
         * Call this method about three times and print out the values of all the four parameters after each method call.
         */
         static void CalculationOfIntegers(int number1, int number2, out int sum, out int difference)
         {
            sum = number1 + number2;
            if (number1 > number2)
                difference = number1 - number2;
            else
                difference = number2 - number1;
         }
        #endregion
        #region Question 5
        /*
         * 5.	Write a method with header static void CalculateTrigValues(double degrees, out double sine, 
         * out double cosine, out double tangent). The method will use the first argument to compute the values
         * of the other three arguments. Used the method Math.Sin, Math.Cos and Math.Tan to compute the second to fourth
         * arguments respectively. [radians = degrees * Math.Pi /180]. In the Main() method, invoke this method 20 times
         * with the first argument taking the values 0, 5, 10, … 95 and display the four arguments in a professional tabular format.
         */
        static void CalculateTrigValues(double degrees, out double sine, out double cosine, out double tangent)
        {
            sine = Math.Sin(degrees * Math.PI / 180);
            cosine = Math.Cos(degrees * Math.PI / 180);
            tangent = Math.Tan(degrees * Math.PI / 180);
        }
        #endregion
        #region Question 6
        /*
         * 6.	Write a method that takes three parameters of type double: the first represents an angle, the other two represents
         * the sine and cosine of the angle respectively. The method must be able to change the actual value of the second and 
         * third argument. In your Main() method, call this method ten times with values 0.50, 0.51, 0.52 … 0.59 and printout 
         * the values for angle, sine and cosine in a tabular format
         */
         static void CalculateTrigValues(double angle, out double sine, out double cosine)
         {
            sine = Math.Sin(angle);
            cosine = Math.Cos(angle);
         }
        #endregion
        #region Question 7
        /*
         *7. A quadratic equation is one in the form of ax2+bx+c = 0. Normally, there are two solutions to such equations
         * given by the expression x=(-b∓√(b^2-4ac))/2a.The Write a method that takes five double arguments, the first three
         * represents a, b and c respectively and the last two the solutions to the equation. [You can check your implementation,
         * the quadratic equation 12x2+x-6 will yield solutions -0.750 & 0.667]
         */
         static void CalculateQuadraticEquation(double a, double b, double c, out double solution1, out double solution2)
         {
            solution1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            solution2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
         }
        #endregion
    }
}