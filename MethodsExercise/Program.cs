namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi there, what is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"it's nice to meet you {userName}. \n" +
                              $"the supperbowl is coming up. \n" +
                              $"what is your favorite gameday snack?");
            string snackName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"oooo {snackName} those are the best! \n" +
                              $"what about your favorite drink?...");
            Console.WriteLine();
            string drinkName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"{drinkName} and {snackName} sounds great! \n" +
                              $"i'll be at your house 30 minutes before, \n" +
                              $"first Down make sure you have the {snackName} \n" +
                              $"and the {drinkName} ready. See you Game Day!");
        }
    }
}
