namespace Fundamentals1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringsAndStringMethods();
            ArithmeticAndArithmeticMethods();
            FloatMethods();
            ComparisonsAndConditionals();
        }

        private static void StringsAndStringMethods()
        {
            string fundamentalsString = ("I’m in Game 1377: Scripting for Game Designers");
            Console.Write(fundamentalsString + "\n");
            Console.WriteLine(fundamentalsString.ToUpper());
            Console.WriteLine(fundamentalsString.ToLower());
            Console.WriteLine(fundamentalsString.Substring(7));
            Console.WriteLine(fundamentalsString.Substring(7, 10));
            Console.WriteLine(fundamentalsString.Substring(7, 1));
        }

        private static void ArithmeticAndArithmeticMethods()
        {
            Console.WriteLine("Enter a number");
            string? stringInput1 = Console.ReadLine();
            int intInput1 = Convert.ToInt32(stringInput1);

            Console.WriteLine("Enter a second number");
            string? stringInput2 = Console.ReadLine();
            int intInput2 = Convert.ToInt32(stringInput2);


            Console.WriteLine("Addition = " + (intInput1 + intInput2));
            Console.WriteLine("Subtraction = " + (intInput1 - intInput2));
            Console.WriteLine("Multiplication = " + (intInput1 * intInput2));
            Console.WriteLine("Division = " + (Convert.ToSingle(intInput1) / intInput2));
            Console.WriteLine("Modulo = " + (intInput1 % intInput2));
        }

        private static void FloatMethods()
        {
            Console.WriteLine("Enter a number with decimals");
            string? stringInput1 = Console.ReadLine();
            float floatInput1 = Convert.ToSingle(stringInput1);
               
            Console.WriteLine("Enter a second number with decimals");
            string? stringInput2 = Console.ReadLine();
            float floatInput2 = Convert.ToSingle(stringInput2);

            Console.WriteLine("floatInput2 = " + floatInput2);
            floatInput2 = floatInput2 + floatInput1;
            Console.WriteLine("floatInput2 = " + floatInput2);
            floatInput2 = floatInput2 - floatInput1;
            Console.WriteLine("floatInput2 = " + floatInput2);
            floatInput2 = floatInput1 * floatInput2;
            Console.WriteLine("floatInput2 = " + floatInput2);
            floatInput2 = floatInput2 / floatInput1;
            Console.WriteLine("floatInput2 = " + floatInput2);
        }

        private static void ComparisonsAndConditionals()
        {
            Console.WriteLine("Enter the first number");
            string? stringInput1 = Console.ReadLine();
            int intInput1 = Convert.ToInt32(stringInput1);

            Console.WriteLine("Enter the second number");
            string? stringInput2 = Console.ReadLine();
            int intInput2 = Convert.ToInt32(stringInput2);

            if (intInput1 == intInput2)
            {
                Console.WriteLine("Inputs 1 and 2 are the same.");
            }
            else if (intInput1 > intInput2)
            {
                Console.WriteLine("Input 1 is greater than input 2");
            }
            else
            {
                Console.WriteLine("Input 1 is less than Input 2");
            }

        }
    }
}
