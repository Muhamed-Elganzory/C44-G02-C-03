using System.ComponentModel;

namespace C44_G02_C_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            Console.WriteLine("Please Enter Your Number");
            int number = int.Parse(Console.ReadLine());
            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            #endregion

            #region 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            Console.WriteLine("Please Enter Your Number");
            int _Number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("That Number is Negative");
            }
            else
            {
                Console.WriteLine("That Number is Positive");
            }
            #endregion

            #region 3- Write a program that takes 3 integers from the user then prints the max element and the min element.
            Console.WriteLine("Please Enter Your First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Your Second Number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Your Third Number");
            int num3 = int.Parse(Console.ReadLine());

            int max = num1;
            int min = num1;

            if (num2 > max)
            {
                max = num2;
            }
            if (num3 > max)
            {
                max = num3;
            }

            if (num2 < min)
            {
                min = num2;
            }
            if (num3 < min)
            {
                min = num3;
            }
            Console.WriteLine($"Max {max} Min {min}");
            #endregion

            #region 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            Console.WriteLine("Please Enter Your Number");
            int _number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("That Number is Even");
            }
            else
            {
                Console.WriteLine("That Number is Odd");
            }
            #endregion

            #region 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            Console.WriteLine("Please Enter Your Character");
            char character = char.Parse(Console.ReadLine());

            switch (character)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("That Character is a vowel chars");
                    break;

                default:
                    Console.WriteLine("That Character is a consonant");
                    break;
            }
            #endregion

            #region 10- Write a program to enter marks of five subjects and calculate total, average and percentage.
            Console.WriteLine("Please Enter Subject 1");
            int sub1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Subject 2");
            int sub2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Subject 3");
            int sub3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Subject 4");
            int sub4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter Subject 5");
            int sub5 = int.Parse(Console.ReadLine());

            int total = sub1 + sub2 + sub3 + sub4 + sub5;
            double average = total / 5;

            double percentage = (total / 500.0) * 100;

            Console.WriteLine($"Total: {total}, Average: {average}, Percentage: {percentage}%");
            #endregion

            #region 11- Write a program to input the month number and print the number of days in that month.
            Console.WriteLine("Please Enter Month Number");
            int month = int.Parse(Console.ReadLine());
            int daysInMonth;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    daysInMonth = 31;
                    break;
                case 2:
                    daysInMonth = 28;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    daysInMonth = 30;
                    break;
                default:
                    Console.WriteLine("Invalid Month Number");
                    break;
            }
            #endregion

            #region 12 - Write a program to create a Simple Calculator.
            Console.WriteLine("Please Enter Your Number");
                double _num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Please Choice Arithmetic Operation: ( +, -, *, /)");
                char operation = char.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter Your Second Number");
                double _num2 = double.Parse(Console.ReadLine());
                double result;

                switch (operation)
                {
                    case '+':
                        result = _num1 + _num2;
                        Console.WriteLine($"Result: {_num1} + {_num2} = {result}");
                    break;
                    case '-':
                        result = _num1 > _num2 ? _num1 - _num2 : _num2 - _num1;
                        Console.WriteLine($"Result: {_num1} - {_num2} = {result}");
                    break;
                    case '*':
                        result = _num1 * _num2;
                        Console.WriteLine($"Result: {_num1} * {_num2} = {result}");
                    break;
                    case '/':
                        if (_num2 == 0 || _num1 == 0)
                        {
                            Console.WriteLine("Division by zero is not allowed.");
                            return;
                        }
                        result = _num1 > _num2 ? _num1 / _num2 : _num2 / _num1;
                        Console.WriteLine($"Result: {_num1} / {_num2} = {result}");
                    break;
                }
            #endregion
        }
    }
}
