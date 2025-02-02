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
            int intInput1 = 10;
            int intInput2 = 3; 
            Console.WriteLine("Addition = " + (intInput1 + intInput2));
            Console.WriteLine("Subtraction = " + (intInput1 - intInput2));
            Console.WriteLine("Multiplication = " + intInput1 * intInput2);
            Console.WriteLine("Division = " + (Convert.ToSingle(intInput1) / intInput2));
            Console.WriteLine("Modulo = " + intInput1 % intInput2);
        }

        private static void FloatMethods()
        {
            float floatInput1;
            float floatInput2;
            floatInput1 = 10f;
            floatInput2 = 15f;
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
            int intInput1;
            int intInput2;
            intInput1 = 20;
            intInput2 = 30;
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
