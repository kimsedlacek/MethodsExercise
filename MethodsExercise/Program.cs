namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Holidays();
            Console.WriteLine();
            Add();
            Console.WriteLine();
            Subtract();
            Console.WriteLine();
            Multiply();
            Console.WriteLine();
            Division();

        }

        public static void Holidays()
        {
            Console.WriteLine("We hope you enjoyed the Winter Fesitval!\nPlease take our brief survey so we can make it even" +
                " better next year.\nType your First Name below to begin the Survey:");
            string name = Console.ReadLine();

            Console.WriteLine($"Thank you {name}! First please answer; I attended the Winter Festival with a child or children " +
                $"under the age of 12: True or False");
            bool withChild = bool.Parse(Console.ReadLine());

            Console.WriteLine("Please tell us what your favorite part of the festival was:\n* Tree Lighting\n* Clydesdale " +
                "Carriage Ride\n* Ice Skating\n* Food Trucks\n* Games & Activities\n* Santa visit");
            string favoriteActivity = (Console.ReadLine());

            Console.WriteLine("Nice, what is your favorite song that the carolers sang?");
            string favoriteSong = Console.ReadLine();

            Console.WriteLine("Wonderful! Do you have any suggestions for furture Winter Festivals or other town activities?" +
                "\nIf not, please type no, if so, please enter here:");
            string suggestions = Console.ReadLine();

            Console.WriteLine($"Thank you again {name} for attending the fesival and for participating in this survey. " +
                $"We are so glad you enjoyed the {favoriteActivity}! We hope to see you next year, and we'll be sure " +
                $"to have the carolers keep \"{favoriteSong}\" on their song list!");

        }

            public static void Add()
            {
                Console.WriteLine("Let's do an additon problem, give me one number:");
                int add1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Now give me a second number:");
                int add2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"{add1} + {add2} = {add1 + add2}");

            }

            public static void Subtract()
            {
                Console.WriteLine("Now let's subtract, give me a number:");
                int sub1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"And what number do you want to subrtract from {sub1}?");
                int sub2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"{sub1} - {sub2} = {sub1 - sub2}");
            }

            public static void Multiply()
            {
                Console.WriteLine("Multiplication, 1st Number:");
                int mul1 = int.Parse(Console.ReadLine());
                Console.WriteLine("2nd Number: ");
                int mul2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"{mul1 * mul2} is {mul1} x {mul2}");

            }

            public static void Division()
            {
                Console.WriteLine("Division-Give me a whole number for the numerator:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Give me another whole number for the denominator");
                int den2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"{num1} divided by {den2} is {num1 / den2} or rounds up to {num1 / den2}");

            }


        }

    }

 
