using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 Tester
            DisplayHorizontalStars(0);
            Console.WriteLine();
            DisplayHorizontalStars(5);
            Console.WriteLine();
            DisplayHorizontalStars(10);
            #endregion
            #region Question 2 Tester
            DisplayVerticalStars(0);
            Console.WriteLine();
            DisplayVerticalStars(5);
            Console.WriteLine();
            DisplayVerticalStars(10);
            #endregion
            #region Question 3 Tester
            //CalculateVolume(1);
            //CalculateVolume(2);
            //CalculateVolume(10);
            #endregion
            #region Question 4 Tester
            //CalculateSellTax(10, "on");
            //CalculateSellTax(1, "On");
            //CalculateSellTax(20, "QC");
            //CalculateSellTax(100, "qC");
            //CalculateSellTax(25, "BC");
            #endregion
            #region Question 5 Tester
            //CelciusToFahrenheit(0);
            //CelciusToFahrenheit(50);
            //CelciusToFahrenheit(95);
            #endregion
            #region Question 6 Tester
            //KilometerToMiles(10, 1, 5);
            //KilometerToMiles(1, 0.5, 5);
            //KilometerToMiles(10, 10, 5);
            #endregion
            #region Question 7 Tester
            //DisplaySineTable(0, 0.1, 5);
            //DisplaySineTable(0.5, 0.05, 5);
            //DisplaySineTable(1, 0.1, 5);
            #endregion
            #region Question 8 Tester
            CentimeterToMeter(90);
            CentimeterToMeter(120);
            CentimeterToMeter(275);
            #endregion
        }
        #region Question 1
        /*
         * 1. Write a method called DisplayHorizontalStars(int numberOfStars). This method will output the number of stars
         * horizontally specified by its argument. Call the DisplayHorizontalStars() method three times from your
         * program Main() method, supplying 0, 5 and 10 respectively for the number of stars
         */
        static void DisplayHorizontalStars(int numberOfStars)
         {
            for (int i = 0; i < numberOfStars; i++)
            {
                Console.Write("*");
            }
        }
        #endregion

        #region Question 2
        /*
         2. Write a method similar to the one above that displays a vertical line of stars. 
         Call this method three times with arguments 0, 5 and 10 respectively.
         */
        static void DisplayVerticalStars(int numberOfStars)
        {
            for (int i = 0; i<numberOfStars; i++)
            {
                Console.WriteLine("*");
            }
        }
        #endregion
        #region Question 3
        /*
         *2. Write a method that accepts an argument of type double. The method will calculate and display the volume
         * of a sphere with radius specified by its argument. [V=4/3  πr^3]. 
         * Call this method from your main three times, with arguments 1, 2, and 10 respectively. 
         * The answers are 4.1888, 33.5103 and 4188.7902 respectively. Use Math.PI for the value of π
         */
         static void CalculateVolume(double radius)
         {
            double volume = 4 * Math.PI * (radius * radius * radius) / 3;
            Console.WriteLine($"A sphere of radius {radius} will have a volume of {volume :f4}");
         }
        #endregion
        #region Question 4
        /*
         * 4. Write a method that takes two arguments: a cost price and a two-letter province code. It will calculate
         * and display the selling price. (If province is Ontario a tax of 13% is added to the price, if the province
         * is Quebec a tax of 17% is added to the cost price. There is no tax for the rest of the provinces and territories). 
         * In your main, call this method enough times to fully test it
         */
         static void CalculateSellTax(double costPrice, string provinceCode)
         {
            double sellTax;
            switch (provinceCode.ToLower())
            {
                case "on":
                    sellTax = 0.13 * costPrice;
                    break;
                case "qc":
                     sellTax = 0.17 * costPrice;
                    break;
                default:
                     sellTax = 0.0 * costPrice;
                    break;
            }
            Console.WriteLine($"The tax on an item {costPrice :C} in {provinceCode} will be {sellTax :C}");
         }
        #endregion
        #region Question 5
         /*
          * 5. Write a method that takes a single argument of type double. The will display a Celsius to Fahrenheit
          * conversion table. The starting temperature is indicated by the argument and it will display 10 lines in 
          * increments of 1. [Fahrenheit = 9/5 Celsius + 32]. 
          * In your main call this method two times, each time with a different value.
          */
         static void CelciusToFahrenheit(double startingTemperature)
         {
            for (int i = 0; i < 10; i++)
            {
               double fahrenheit = (9 * startingTemperature) / 5 + 32;
               Console.WriteLine($"{startingTemperature, 5} {fahrenheit, 10:f2}");
               startingTemperature ++;
            }
         }
        #endregion
        #region Question 6
        /*
         * 6. Write a method that takes the following arguments: a starting km value of type double, an increment size
         * of type double and the number of lines of type int. Your program will create and display a kilometer to miles 
         * conversion table. [miles = km * 0.621371]. In your main call this method three times, each time with different values.
         */
         static void KilometerToMiles(double startingKmValue, double increment, int numberOfLines)
         {
            const double VALUE = 0.621371;
            for (int i = 0; i < numberOfLines; i++)
            {
                double miles = startingKmValue * VALUE;
                Console.WriteLine($"{startingKmValue,5:f2} {miles,10:f2}");
                startingKmValue += increment;
            }
         }
        #endregion
        #region Question 7
        /*
         * 7. Modify the DisplaySineTable() method in the previous section to accept the start value, 
         * the step size and number of rows as argument to the method.
         */
        static void DisplaySineTable(double startValue, double stepSize, int numberOfRows)
        {
            for (int i = 0; i < numberOfRows; i++)
            {
                Console.WriteLine($"{startValue:f2} {Math.Sin(startValue),10:f2}");
                startValue += stepSize;
            }
        }
        #endregion
        #region Question 8
        /*8. Write a method that converts a person’s height from centimeter to meters and centimeters and display 
         * the result on the console. In your main method, you should call this method three times with argument 
         * 90, 120 and 275. The result is shown in the table below. You do not have to create the table below!
         * Input	Result
         * 90cm	0m 90cm
         * 120cm	1m 20 cm
         * 275cm	2m 75cm
         */
         static void CentimeterToMeter(int centimeter)
         {
            int meter = centimeter / 100;
            int cm = centimeter % 100;
            Console.WriteLine($"{centimeter,5}cm {meter, 10}m {cm,5}cm");
         }
        #endregion
    }
}
