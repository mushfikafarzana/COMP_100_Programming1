using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 Tester
            //int firstNumber = 3, secondNumber = 5;
            //Console.WriteLine($"The difference between {firstNumber} and {secondNumber} is {CaculateDifference(3, 5)} ");
            //firstNumber = 13; secondNumber = 5;
            //Console.WriteLine($"The difference between {firstNumber} and {secondNumber} is {CaculateDifference(13, 5)} ");
            //firstNumber = 23; secondNumber = 5;
            //Console.WriteLine($"The difference between {firstNumber} and {secondNumber} is {CaculateDifference(23, 5)} ");
            //firstNumber = 23; secondNumber = 13;
            //Console.WriteLine($"The difference between {firstNumber} and {secondNumber} is {CaculateDifference(23, 13)} ");
            #endregion
            #region Question 2 Tester
            //double i1 = 1, i2 = 0.1, r1 = 1.5, r2 = 100; 
            //Console.WriteLine($"If current is {i1 :f2}A and Resistance is {r1}ohms then Power will be {CalculatePower(1, 1.5) :f2}W ");
            //Console.WriteLine($"If current is {i2 :f2}A and Resistance is {r2}ohms then Power will be {CalculatePower(0.1, 100) :f2}W");
            #endregion
            #region Question 3 Tester
            //double numberOfCourses = 1, costPerCourse = 500;
            //Console.WriteLine($"{numberOfCourses} courses @ {costPerCourse :C} will cost a total of {CalculateTuitionFee(1, 500) :C} ");
            //numberOfCourses = 5; costPerCourse = 450;
            //Console.WriteLine($"{numberOfCourses} courses @ {costPerCourse:C} will cost a total of {CalculateTuitionFee(5, 450):C} ");
            //numberOfCourses = 5; costPerCourse = 449.99;
            //Console.WriteLine($"{numberOfCourses} courses @ {costPerCourse:C} will cost a total of {CalculateTuitionFee(5, 449.99):C} ");
            //numberOfCourses = 5; costPerCourse = 0;
            //Console.WriteLine($"{numberOfCourses} courses @ no cost supplied will cost a total of {CalculateTuitionFee(5, 0):C} ");
            #endregion
            #region Question 4 Tester
            //double saleAmount = 900;
            //Console.WriteLine($"A sale amount of {saleAmount :C} will yield a comission of {CalculateCommission(900) :C}");
            //saleAmount = 1000;
            //Console.WriteLine($"A sale amount of {saleAmount :C} will yield a comission of {CalculateCommission(1000) :C}");
            //saleAmount = 2000;
            //Console.WriteLine($"A sale amount of {saleAmount :C} will yield a comission of {CalculateCommission(2000) :C}");
            #endregion
            #region Question 5 Tester
            //Console.Write("How many burgers? ");
            //int numberOfBurgers = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"First call gives {CalculateBurgerPrice() :C} ");
            //Console.WriteLine($"Second call gives {CalculateBurgerPrice() :C} ");
            #endregion
            #region Question 6 Tester
            //double earth = 5.972e+24;
            //double moon = 7.348e+22;
            //double distance = 3.844e+8;
            //Console.WriteLine($"Earth: {earth :e} ");
            //Console.WriteLine($"Moon: {moon :e} ");
            //Console.WriteLine($"Distance: {distance :e} ");
            //Console.WriteLine($"Force: {CalculateGravitationalAttraction(5.972e+24, 7.348e+22, 3.844e+8) :e}");
            #endregion
            #region Question 7 Tester
            //double a = 5.83, b = 4.24, c = 8;
            //Console.WriteLine($"a:{a :f2} b:{b :f2} c:{c :f2}  area: {AreaOfTriangle(5.83, 4.24, 8) :f2} "); 
            #endregion
            #region Question 8 Tester
            //double value1 = 0;
            //double value2 = 50;
            //double value3 = 100;
            //Console.WriteLine($"C:{value1,6 :f2}  F:{ConvertCelciusToFahrenheit(0),8 :f2}");
            //Console.WriteLine($"C:{value2,6 :f2}  F:{ConvertCelciusToFahrenheit(50),8 :f2}");
            //Console.WriteLine($"C:{value3,6 :f2}  F:{ConvertCelciusToFahrenheit(100),8 :f2}");
            #endregion
            #region Question 9 Tester
            //double value1 = 0;
            //double value2 = 32;
            //double value3 = 212;
            //Console.WriteLine($"F:{value1,6:f2}  C:{ConvertFahrenheitToCelcius(0),8:f2}");
            //Console.WriteLine($"F:{value2,6:f2}  C:{ConvertFahrenheitToCelcius(32),8:f2}");
            //Console.WriteLine($"F:{value3,6:f2}  C:{ConvertFahrenheitToCelcius(212),8:f2}");
            #endregion
            #region Question 10 Tester
            //double value1 = -196;
            //double value2 = 0;
            //double value3 = 100;
            //Console.WriteLine($"C:{value1,7:f2} K: {ConvertCelsiusToKelvin(-196),8:f2}");
            //Console.WriteLine($"C:{value2,7:f2} K: {ConvertCelsiusToKelvin(0),8:f2}");
            //Console.WriteLine($"C:{value3,7:f2} K: {ConvertCelsiusToKelvin(100),8:f2}");
            #endregion
            #region Question 11 Tester
            //double value1 = -196;
            //double value2 = 0;
            //double value3 = 100;
            //Console.WriteLine($"F:{value1,7:f2} K: {ConvertFahrenheitToKelvin(-196),8:f2}");
            //Console.WriteLine($"F:{value2,7:f2} K: {ConvertFahrenheitToKelvin(0),8:f2}");
            //Console.WriteLine($"F:{value3,7:f2} K: {ConvertFahrenheitToKelvin(100),8:f2}");
            #endregion
            #region Question 12 Tester
            //Console.Write("Enter a value: ");
            //int value = Convert.ToInt32(Console.ReadLine());
            //int square = CalculateIntSquare(value);
            //int cube = CalculateIntCube(square);
            //Console.WriteLine($"Original number: {value}, after cubing the square: {cube}");
            #endregion
            #region Question 13 Tester
            double salesAmount = DisplaySalesAmount();
            Console.WriteLine($"Based on your sales amount, comission is {CalculateComission(salesAmount) :C}") ;
            #endregion
        }
        #region Question 1
        /*
         * 1. Write a method called CaculateDifference(int firstNumber, int secondNumber). This method will calculate
         * and return the difference between the two numbers i.e. it will subtract the smaller one from the larger one
         * and then return that value. Call the CaculateDifference() method four times from your program Main() method
         * supplying different arguments each time. You must display the returned value for each call
         */
         static int CaculateDifference(int firstNumber, int secondNumber)
         {
            int difference;
            if (firstNumber > secondNumber)

                difference = firstNumber - secondNumber;
            else
                difference = secondNumber - firstNumber;

            return difference;
         }
        #endregion
        #region Question 2
        /*
         * 2. Write a method called CalculatePower(double current, double resistance). The method will calculate and 
         * return the electrical power dissipated in a circuit. [P=I2R]. Call the CalculatePower() method two times 
         * from your program Main() method supplying different arguments each time and displaying the returned value each time.
         */
         static double CalculatePower(double current, double resistance)
         {
            double power = current * current * resistance;
            return power;
         }
        #endregion
        #region Question 3
        /*
         * 3. Write a method called CaculateTuitionFee(int numberOfCourses, double costPerCourse = 449.99). This method
         * will calculate and return the required fees amount. [Fees = number of courses * cost per course + 15.25]. 
         * Call the CaculateTuitionFee() method four times from your program Main() method supplying different arguments each time.
         */
         static double CalculateTuitionFee(int numberOfCourses, double costPerCourse)
         {
            double tuitionFees;
            const double VALUE = 15.25, COURSE = 449.99;
            if (costPerCourse == 0)
            { 
                tuitionFees = numberOfCourses * COURSE + VALUE;
            }
            else
            { 
                tuitionFees = numberOfCourses * costPerCourse + VALUE;
            }
            return tuitionFees;
         }
        #endregion
        #region Question 4
        /*
         * 4.	Write a method called CalculateCommission(double saleAmount). This method will calculate and return a sales 
         * representation’s commission. [over $1000 the commission will be 1%]. Call the CalculateCommission() method three
         * times from your program Main() method, supplying arguments 900, 1000 and 2000.
         */
         static double CalculateCommission(double saleAmount)
         {
            double comission;
            if (saleAmount > 1000)
                comission = (saleAmount - 1000) * 0.01;
            else
                comission = 0;

            return comission;
        }
        #endregion
        #region Question 5
        /*
         * 5.	Write a method that does not take any argument. The method will prompt the user for the number of burgers 
         * that he wants to buy. The method will calculate and return the amount of money that will be required. 
         * [One burger cost $1.39]. From your program Main() method, call the above method two times 
         */
         static double CalculateBurgerPrice()
         {
            int numberOfBurgers = Convert.ToInt32(Console.ReadLine());
            const double PRICE = 1.39;
            double totalPrice = numberOfBurgers * PRICE;
            return totalPrice;
         }
        #endregion
        #region Question 6
        /*
         * 6. “Newton's law of universal gravitation states that every point mass in the universe attracts every other point
         * mass with a force that is directly proportional to the product of their masses and inversely proportional to the 
         * square of the distance between them.” Write a method called CalculateGravitationalAttraction() that takes three double
         * arguments (masses of the two bodies and the distance between them). The method will calculate and return the force of
         * attraction between them. [F=G (m_1 m_2)/d^2  , where G = 6.673x10-11]. In your main call this method with the masses
         * of the earth, moon and the distance between them and display the resulting force. Mass of Earth = 5.972 × 1024,
         * moon = 7.348 × 1022, Distance = 384,400000m. [Answer 1.99 x 1020N]
         */
         static double CalculateGravitationalAttraction(double firstMass, double secondMass, double distance)
         {
            const double G = 6.673e-11;
            double value = G * firstMass * secondMass;
            double force = value / (distance * distance);
            return force;
         }
        #endregion
        #region Question 7
        /*
         *7. Heron’s formula allows you to calculate the area of any triangle given the length of the three sides. Write a method
         * that takes the length of the three sides and return the area of the specified triangle. A=√(s(s-a)(s-b)(s-c) ) 
         * where s=(a+b+c)/2. In your main call this method with arguments 5.83, 4.24 and 8.00, and display the area. [Answer = 12.0].
         */
         static double AreaOfTriangle(double firstSide, double secondSide, double thirdSide)
         {
            double S = (firstSide + secondSide + thirdSide) / 2;
            double area = Math.Sqrt(S*(S - firstSide)* (S - secondSide) * (S - thirdSide));
            return area;
         }
        #endregion
        #region Question 8
        /*
         * 8.	Write a method called ConvertCelsiusToFahrenheit that takes a double argument. The method will calculate and return
         * the Fahrenheit equivalent of the argument. [F = C * 9 / 5 + 32]. In your main call this method three times with arguments 
         * 0, 50 and 100 respectively and display the results.
         */
         static double ConvertCelciusToFahrenheit(double celciusValue)
         {
            double fahrenheitValue = (celciusValue * 9 / 5) + 32;
            return fahrenheitValue;
         }
        #endregion
        #region Question 9
        /*
         * 9.	Write a method called ConvertFahrenheitToCelsius that takes a double argument. The method will calculate and return
         * the Celsius equivalent of the argument. [C = (F – 32) * 5 / 9]. In your main call this method three times with arguments
         * 0, 32 and 212 respectively and display the results.
         */
        static double ConvertFahrenheitToCelcius(double fahrenheitValue)
        {
            double celciusValue = (fahrenheitValue - 32) * 5 / 9;
            return celciusValue;
        }
        #endregion
        #region Question 10
        /*
         * 10.	Write a method called ConvertCelsiusToKelvin that takes a double argument. The method will calculate and return the
         * Kelvin equivalent of the argument. [K = C + 273.15]. In your main call this method three times with arguments
         * -196, 0 and 100 respectively and display the results.
         */
        static double ConvertCelsiusToKelvin(double celciusValue)
        {
            const double K_VALUE = 273.15;
            double kelvinValue = celciusValue + K_VALUE;
            return kelvinValue;
        }
        #endregion
        #region Question 11
        /*
         * 11. Write a method call ConvertFahrenheitToKelvin that takes a double argument. The method will calculate and return the
         * Kelvin equivalent of the argument. [DO NOT RE-CODE THIS METHOD. Use the two previous methods to assist in your computation]. 
         * In your main call this method three times and display the results
         */
        static double ConvertFahrenheitToKelvin(double fahrenheitValue)
        {
            double celciusValue = ConvertFahrenheitToCelcius(fahrenheitValue);
            double kelvinValue = ConvertCelsiusToKelvin(celciusValue);
            return kelvinValue;
        }
        #endregion
        #region Question 12
        /*
         * 12.	Write two methods: Square(int) and Cube(int), these methods return the square and the cube of its argument. 
         * In your main method prompt the user for an integer, then pass this integer to the Square method and then pass the
         * results to the Cube method. In the main method print out the final results.
         */
         static int CalculateIntSquare(int value)
         {
            int square = value * value;
            return square;
         }
        
        static int CalculateIntCube(int value)
        {
            int cube = value * value * value;
            return cube;
        }
        #endregion
        #region Question 13
        /*
         * 13.	Write two methods that will be called from main. The first method should prompt the user for his daily sales amount.
         * The method should accept and return this amount. The second method should calculate and return his commission based on 
         * the following: 0-999 3%, 1000-2999 4% and over 3000 5%. In your main call the two methods and display the results in a
         * readable manner.
         */
         static double DisplaySalesAmount()
         {
            Console.Write("Enter your sales amount: ");
            double salesAmount = Convert.ToDouble(Console.ReadLine());
            return salesAmount;
         }
        static double CalculateComission(double salesAmount)
        {
            double comission;
            if (salesAmount >= 0 && salesAmount <= 999)

                comission = 0.03 * salesAmount;

            else if (salesAmount >= 1000 && salesAmount <= 2999)

                comission = 0.04 * salesAmount;

            else if (salesAmount >= 3000)

                comission = 0.05 * salesAmount;
            else
            { 
                Console.WriteLine("Error! ");
                comission = 0;
            }
            return comission;
        }
        #endregion
    }
}
