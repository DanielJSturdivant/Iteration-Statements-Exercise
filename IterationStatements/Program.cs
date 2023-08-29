namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintOneThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void PrintThree()
        {
            int i = 3;
            do
            {
                Console.WriteLine(i);
                i += 3;
            } while (i <= 999);
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void TwoIntegers(int a, int b)
        {
            //Console.WriteLine("Give me a number");
            //var a = int.Parse(Console.ReadLine());
            
            

            //Console.WriteLine("Give me a number to compare to the other");
            //var b = int.Parse(Console.ReadLine());
            

            if (a == b)
            {
                Console.WriteLine($"{a} and {b} are equal");
            }
            else
            {
                Console.WriteLine($"{a} and {b} are not equal");
            }
        }
        
        //Write a method to check whether a given number is even or odd

        public static void CheckEvenOdd()
        {
            Console.WriteLine("Give me a number to check if it is even or odd");
            var i = int.Parse(Console.ReadLine());


            var t = i % 2;



            if (t == 0)
            {
                Console.WriteLine("It is even");
            }
            else if (t == 1)
            {
                Console.WriteLine("It is odd");
            }
            else if (t == -1)
            {
                Console.WriteLine("It is odd");
            }
            else
            {
                Console.WriteLine($"{i} is not a whole number");
            }
        }
        
        //Write a method to check whether a given number is positive or negative

        public static void CheckPN()
        {
            Console.WriteLine("Give me a number to check if it is positive or negative");
            var i = int.Parse(Console.ReadLine());
            
            if (i > 0)
            {
                Console.WriteLine("It is positive");
            }
            else if (i < 0)
            {
                Console.WriteLine("It is negative");
            }
            else if (i == 0)
            {
                Console.WriteLine("Zero is neither positive nor negative");
            }
            else
            {
                Console.WriteLine("This is an error message");
            }
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static void ReadAge()
        {
            Console.WriteLine("Give me your age");
            var age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("You are too young to vote");
            }
            else
            {
                Console.WriteLine("You are old enough to vote");
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void CheckRange()
        {
            Console.WriteLine("Give me a number to see if it is in the range -10 and 10");
            var i = int.Parse(Console.ReadLine());

            if (i <= 10 && i >= -10)
            {
                Console.WriteLine("It is in the range of -10 and 10");
            }
            else
            {
                Console.WriteLine("It is NOT in the range of -10 and 10");
            }
        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void DisplayTable(int b)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{b} * {i} = {b*i}");
                
            }
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintOneThousand();
            PrintThree();
            TwoIntegers(2, 2);
            CheckEvenOdd();
            CheckPN();
            ReadAge();
            CheckRange();
            DisplayTable(7);
        }
    }
}
