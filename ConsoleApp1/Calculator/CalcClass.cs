using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class CalcClass
    {
        // These are the calculation method of the calculator.
        public static int Add(int input1, int input2)
        {
            int result = input1 + input2;
            Console.WriteLine($"The addition of the two numbers {input1} and {input2} is " + result);
            return result;
        }

        public static int Sub(int input1, int input2)
        {
            int result = input1 - input2;
            Console.WriteLine($"The substraction of the two numbers {input1} and {input2} is " + result);
            return result;
        }

        public static int Multi(int input1, int input2)
        {
            int result = input1 * input2; 
            Console.WriteLine($"The multiplication of the two numbers {input1} and {input2} is " + result);
            return result;
        }

        public static int Div(int input1, int input2)
        {
            int result = input1 / input2;
            Console.WriteLine($"The division of the two numbers {input1} and {input2} is " + result);
            return result;
        }


        // Asks user if they want to continue for more calculation. Reruns the method!
        public static void Cont()
        {
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Do you want to continue? Y/N");
            Console.WriteLine("----------------------------------------------");
            var conti = Console.ReadLine().ToLower();

            if (conti == "y"){
                MainRun();
            } 
            else {
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("              Have a good day! :)             ");
                Console.WriteLine("----------------------------------------------");
            }
        }


        // This is the main primary function which is called in the main method i.e program.cs and executed.
        public static void MainRun()
        {

            int input1 = 0;
            int input2 = 0;


            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("         Welcome to Console Calculator!       ");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Choice an option from the given list > ");
            Console.WriteLine("Enter 1: Returns Addition of two numbers.");
            Console.WriteLine("Enter 2: Returns Substraction of two numbers.");
            Console.WriteLine("Enter 3: Returns Multiplication of two numbers.");
            Console.WriteLine("Enter 4: Returns Divison of two numbers.");
            Console.WriteLine("Enter 5: Returns Jagged Arrays.");
            Console.WriteLine("Enter 6: Returns SingleDimensional Arrays.");
            Console.WriteLine("Enter 7: Returns ImplicitlyTyped Arrays.");
            Console.WriteLine("Enter 8: Returns MultiDimensional Arrays.");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("----------------------------------------------");
            var opt = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Enter the two numbers for calculation: ");
            Console.WriteLine("Enter the first number: ");
            input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Enter the second number: ");
            input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------------------");


            // Takes the option input in integer and finds the correct condition and executes the task by calling the calculation methods!
            switch (opt)
            {
                case 1:
                    CalcClass.Add(input1, input2);
                    Cont();
                    break;
                case 2:
                    CalcClass.Sub(input1, input2);
                    Cont();
                    break;
                case 3:
                    CalcClass.Multi(input1, input2);
                    Cont();
                    break;
                case 4:
                    CalcClass.Div(input1, input2);
                    Cont();
                    break;


            }
        }
    }
}
