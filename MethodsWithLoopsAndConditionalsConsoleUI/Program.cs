using System;
using System.Dynamic;

namespace MethodsWithLoopsAndConditionalsConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers();

            ThreeEachTime();

            int userNum1 = UserInput();
            int userNum2 = UserInput1();

            bool areEqual = EqualOrNot(userNum1, userNum2);
            Console.WriteLine($"{userNum1} is equal to {userNum2}: {areEqual}");

            EvenOrOdd(userNum1);

            PosOrNeg(userNum1);

            Console.WriteLine("Hello, what is your age? ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Could not identify. Please enter your age with a number");
            }

            VotingAge(age);

            int userNumber = UserInput();
            Range(userNumber);

            userNumber = UserInput();
            int multiplyOutput = UserInput();
            MultiplicationTable(userNumber, multiplyOutput);

            UserInput();
            int[] randomNumbers = numbersArray(userNumber);
            foreach (var number in randomNumbers)
            {
                Console.WriteLine(number);
            }

            int sumOfElements = sumArray(randomNumbers);
            Console.WriteLine($"The sum of integers in the array = {sumOfElements}");

            userNumber = UserInput();
            Cubes(userNumber);

        }

        private static void Cubes(int cubeNumber)
        {
            double cubed = 0;
            for (int i = 1; i <= cubeNumber; i++)
            {
                cubed = (int)Math.Pow(i, 3);
                Console.WriteLine($"Number is {i} and the cube of {i} is: {cubed}");
            }
        }

        private static int sumArray(int[] randomNumbers)
        {
            int sum = 0;

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                sum += randomNumbers[1];
            }

            return sum;
        }

        private static int[] numbersArray(int userNumber)
        {
            int[] randos = new int[userNumber];
            Random rng = new Random();

            for(int i =0; i < randos.Length; i ++)
            {
                randos[i] = rng.Next(501);
            }

            return randos;
        }

        private static void MultiplicationTable(int userNumber, int multiplyOutput)
        {
            int product = 0;

            for (int i = 1; i <= multiplyOutput; i++)
            {
                product = userNumber * i;
                Console.WriteLine($"{userNumber} * {i} = {product}");
            }
        }

        private static void Range(int userNumber)
        {
            if (userNumber >= -10 && userNumber <= 10)
            {
                Console.WriteLine($"{userNumber} is in the correct range.");
            }

            else
            {
                Console.WriteLine($"{userNumber} is out of the range required.");
            }
        }

        private static void VotingAge(int age)
        {
            if( age < 18)
            {
                Console.WriteLine($"Sorry, you must be 18 or older to Vote. Come back in {18 - age} years.");
            }

            else
            {
                    Console.WriteLine($"Great, since your age is {age} or older you can vote");
            }
        }

        public static void PosOrNeg(int x)
        {
           if (x > 0)
            {
                Console.WriteLine("Your number is a positive number");
            }

            else
            {
                Console.WriteLine("Your number is not a positive number");

            }
        }

        public static void EvenOrOdd(int yourNumber)
        {
            int num1 = 11 % 2;

            if (num1 % 11 == 0)
            {
                Console.WriteLine($"{yourNumber} is even!");
            }

            else if (num1 % 11 != 0)
            {
                Console.WriteLine($"{yourNumber} is odd!");
            }

            else
            {
                Console.WriteLine($"{yourNumber} is not a mumber!");
            }
        }

        public static int UserInput()
        {
            Console.Write("Kindly provide a number: ");
            int UserInput = int.Parse(Console.ReadLine());

            return UserInput;
        }

        public static int UserInput1()
        {
            Console.Write("Kindly provide another number: ");
            int UserInput = int.Parse(Console.ReadLine());

            return UserInput;
        }

        public static bool EqualOrNot(int userNum1, int userNum2)
        {
            return userNum1 == userNum2;

            //int x = 15;
            //int y = 25;

            //if (x == y)
            //{
            //    Console.WriteLine("x is equal to y");
            //}

            //else
            //{
            //    Console.WriteLine("x is not equal to y");
            //
        }

        public static void ThreeEachTime()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintNumbers()
        {
            for (int i = 1000; i <= 1000 && i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void PauseConsole()
        {
            Console.WriteLine();
            Console.ReadLine();
        }

        //Console.WriteLine("Give me a number, any number!!");
        //int userInput = int.Parse(Console.ReadLine());

        //int[] array = ArrayCreator(userInput);

        //foreach(int number in array)
        //{
        //    Console.WriteLine(number);
        //}


        //public static int[] ArrayCreator(int userNumber)
        //{
        //    int[] customArray = new int[userNumber];

        //    Random rng = new Random();

        //    for(int index = 0; index < customArray.Length; index++) 
        //    {
        //        customArray[index] = rng.Next(100);
        ////    }

        //    return customArray;
        //}

    }
}
