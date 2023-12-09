namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Holidays();
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

            Console.WriteLine("What is your favorite song that the carolers sang?");
            string favoriteSong = Console.ReadLine();

            Console.WriteLine("Wonderful! Do you have any suggestions for furture Winter Festivals or other town activities?" +
                "\nIf not, please type no, if so, please enter here:");
            string suggestions = Console.ReadLine();

            Console.WriteLine($"Thank you again {name} for attending the fesival and for participating in this survey. " +
                $"We are so glad you enjoyed the {favoriteActivity}! We hope to see you next year, and we'll be sure " +
                $"to have the carolers keep {favoriteSong} on their song list!");

        }

    }
}
