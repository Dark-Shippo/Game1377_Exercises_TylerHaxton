namespace Fundamentals_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            float[] floatArray = { 1.1f, 2.1f, 3.1f, 4.1f, 5.1f };
            double[] doubleArray = { 1.1, 2.1, 3.1, 4.1, 5.1 };
            SwitchFunction();
            ArraysAndLoopsFunction();
            ArrayRange();
            MethodsFunctionArrayA(intArray);
            OverloadMethod1(floatArray);
            OverloadMethod1(doubleArray);
            ConvertIntArrayToFloat(intArray);
            Console.WriteLine(OverloadAverage(floatArray));
            Console.WriteLine(OverloadAverage(doubleArray));
        }

        static void SwitchFunction()
        {
            Console.WriteLine("Input a WASD key.");
            var input = Console.ReadKey();
            switch (input.Key) 
            {
                case (ConsoleKey.W):
                    Console.WriteLine("\n" + "You moved up.");
                    break;
                case (ConsoleKey.A):
                    Console.WriteLine("\n" + "You moved left.");
                    break;
                case (ConsoleKey.D):
                    Console.WriteLine("\n" + "You moved right.");
                    break;
                case (ConsoleKey.S):
                    Console.WriteLine("\n" + "You moved down.");
                    break;
                default:
                    Console.WriteLine("\n" + "You just stand there.");
                    break;
            }
        }

        static void ArraysAndLoopsFunction()
        {
            //               0    1   2     3    4    5    6   7    8    9
            int[] array = { 100, 94, 159, -783, 132, 179, 47, 107, 135, 50 };
            for (int i = 9; i != -1; i--)
            {
                Console.WriteLine(array[i]);
            }

            bool foundArrayElement = false;
            while (!foundArrayElement)
            {
                Console.WriteLine("Input any number from the array");
                string? stringInput = Console.ReadLine();
                bool parseSucceeded = int.TryParse(stringInput, out int intInput);
                if (!parseSucceeded)
                {
                    Console.WriteLine("This is an invalid input");
                    continue;
                }
                for (int c = 0; c < array.Length; c++)
                {
                    if (array[c] == intInput)
                    {
                        foundArrayElement = true;
                        break;
                    }
                }
            }

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("This is the array average.");
                Console.WriteLine(array.Average());
            }

            Console.WriteLine("This is every other number in the array");
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(array[i]);
                }

            }

            Console.WriteLine("This is every third number in the Array.");
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 3 == 2)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }

        static void ArrayRange()
        {
            Console.WriteLine("Input array size.");
            int arraySize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input array range minimum.");
            int rangeMin = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input array range maximum.");
            int rangeMax = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[arraySize];

            Random rand = new Random(); 

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(rangeMin, rangeMax);
            }
            
        }

        static void MethodsFunctionArrayA(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
        }

        static float[] OverloadMethod1(float[] x)
        {
            Console.WriteLine("Float array");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            return x;
        }

        static double[] OverloadMethod1(double[] x)
        {
            Console.WriteLine("Double array");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(x[i]);
            }
            return x;
        }

        static float[] ConvertIntArrayToFloat(int[] x)
        {
            Console.WriteLine("Convert Int[] to float[]");
            float[] array = Array.ConvertAll(x, Convert.ToSingle);
            return array;
        }

        static float OverloadAverage(float[] x)
        {
            Console.WriteLine("Find float[] average");
            float[] array = x;
            return (array.Average());
        }

        static double OverloadAverage(double[] x)
        {
            Console.WriteLine("Find double[] average");
            double[] array = x;
            return (array.Average());
        }
    }
}
