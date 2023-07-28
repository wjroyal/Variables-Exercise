namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declare and Initialize variables
            string bandName = "Grateful Dead";
            int startYear = 1965;
            char keyBoard = 'P';
            bool ifYou = true;
            double fareTheeWell = 49.99;
            int lowEnd = 0;
            decimal highEnd = 10000.99m;

            Console.WriteLine($"Arguably, one of the most iconic bands of modern American music is The {bandName}, who first hit the West Coast music scene in\n " +
                $"{startYear}. Now for a bit of trivia. Is it true that the first keyboardist of the band had a name that started with the the letter {keyBoard}?\n " +
                $"If you answered {ifYou.ToString().ToLower()} , then you are correct. On a recent tour with some of the remaining members, known as Dead and Company, " +
                $"face value tickets are actually {fareTheeWell}, but fans most likely paid from as low as ${lowEnd}\n" +
                $"to as high as ${highEnd}");
              
        
        }
    }
}
