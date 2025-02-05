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
            Console.WriteLine("Enter the first number");
            int intInput1 = Console.Read();

            Console.WriteLine("Enter the second number");
            int intInput2; 
            intInput2 = Console.Read();

            Console.WriteLine("Addition = " + (intInput1 + intInput2));
            Console.WriteLine("Subtraction = " + (intInput1 - intInput2));
            Console.WriteLine("Multiplication = " + intInput1 * intInput2);
            Console.WriteLine("Division = " + (Convert.ToSingle(intInput1) / intInput2));
            Console.WriteLine("Modulo = " + intInput1 % intInput2);
        }

        private static void FloatMethods()
        {
            Console.WriteLine("Enter the first float");
            float floatInput1 = Console.Read();

            Console.WriteLine("Enter the second float");
            float floatInput2 = Console.Read();

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
            Console.WriteLine("Enter the first number for comparison");
            int intInput1 = Console.Read();

            Console.WriteLine("Enter the second number for comparison");
            int intInput2 = Console.Read();

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
