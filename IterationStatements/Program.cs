using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace IterationStatements
{
    class Program
    {



        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void OneThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ThreeToNineNinteyNine()
        {

            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }


        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void EqualIntegers()
        {
            Console.WriteLine("Enter two integers");
            int a = 0;
            int b = 0;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("The two integers are the same");
            }
            else
            {
                Console.WriteLine("The two integers are not the same");
            }
        }

        //Write a method to check whether a given number is even or odd
        public static void OddEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void PositiveNegative(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is 0.");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        public static void VotingAge()
        {
            Console.WriteLine("Please enter your age.");
            int age = int.Parse(Console.ReadLine()!);
            if (age >= 18)
            {
                Console.WriteLine("The person is of voting age.");
            }
            else
            {
                Console.WriteLine("The person is two children in a trenchcoat, do not let them vote.");
            }
        }

        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void IsInRange()
        {
            Console.WriteLine("Please enter a number to see if it is in range:");
            int userInput = int.Parse(Console.ReadLine()!);
            userInput = 0;
            if (userInput <= 10 && -10 <= userInput)
            {
                Console.WriteLine("The number is in the range of -10 to 10");
            }
            else if (userInput >= 10 || -10 >= userInput)
            {
                Console.WriteLine("The number is out of range.");
            }
            
        }
       
        
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplyToTwelve()
        {
            Console.WriteLine("Please enter a number:");
            int userInput = int.Parse(Console.ReadLine()!);
            int multiplyBy = 1;
            do
            {
                Console.WriteLine(userInput * multiplyBy);
                multiplyBy++;

            } while (multiplyBy <= 12);
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
        //OneThousand();
        //ThreeToNineNinteyNine();
        //EqualIntegers();
        //OddEven(4);
        //PositiveNegative(0);
        //VotingAge();
        //IsInRange();
        //MultiplyToTwelve();
        }
        
    }
}
