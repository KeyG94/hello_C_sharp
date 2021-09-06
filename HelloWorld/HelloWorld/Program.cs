using System;

namespace Form
{
    class Program
    {
        static void Main(string[] args)
        {
            int interest;
            int compound = 2;

            for (interest = 0; interest <= 25; interest += compound)
                Console.WriteLine($"compound: {compound}^ interest after: {interest} years = {Math.Pow(compound, interest)} value");

            //standard wait.
            Console.ReadLine();

            //Program that finds your dog age
            Console.Write("How old are you?: ");
            int humanAge = Convert.ToInt32(Console.ReadLine());
            //simple calculation
            int dogAge = humanAge * 7;

            Console.WriteLine($"If you were a dog, you would be: {dogAge}yrs old by now!");

            string[] randomWords = { "Hello", "from", "to", "I", "cat", "Jesus", "Wheel", "bowling", "throwing", "take", "the", "use", "drugs", "pepsi", "grab", "jump", "sick", "british", "drive", "swim", "beer", "drunk", "sailor", "table", "train", "inside" };

            Random random = new Random();
            int generatedIndex = random.Next(0, randomWords.Length - 1);

            //constructed story
            for (int i = generatedIndex; i < randomWords.Length; i += generatedIndex)
                Console.Write($"{randomWords[i]} ");

            //Wait for user input
            Console.ReadLine();


            //number guessing game
            Console.WriteLine("Guess the number between 1 or 10");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Random rndNum = new Random();
            int cpuNumber = rndNum.Next(1, 10);

            //Check if user inputs the same value as cpu:
            if (userInput != cpuNumber)
            {
                Console.WriteLine($"The computer says: {cpuNumber}");
                Console.WriteLine($"You have typed: {userInput}");
                Console.WriteLine("Sorry, try again :(");

            }
            else
            {
                Console.WriteLine($"The computer says: {cpuNumber}");
                Console.WriteLine($"You have typed: {userInput}");
                Console.WriteLine("Hurray!");
            }

            //Buzzfeed game
            Console.WriteLine("Select your favorite fast food: burger king, kfc, olive garden, mcdonalds, sonic");

            string userRestaurant = Console.ReadLine();

            switch (userRestaurant)
            {
                case "burger king":
                    //case
                    Console.WriteLine("You're a lion");
                    break;
                case "kfc":
                    // case
                    Console.WriteLine("You're a tiger");
                    break;
                case "olive garden":
                    // case
                    Console.WriteLine("You're a housecat");
                    break;
                case "mcdonalds":
                    // case
                    Console.WriteLine("You're a jaguar");
                    break;
                case "sonic":
                    // case
                    Console.WriteLine("You're a cheetah");
                    break;
                default:
                    //default value
                    Console.WriteLine("You're a nimcompoop");
                    break;
            }


            //Birthday checker
            Console.WriteLine("checking birthday..");
            DateTime birthday = new DateTime(1994, 6, 30);

            string birthdayToCheck = birthday.ToString("MM/dd");
            string today = DateTime.Today.ToString("MM/dd");


            if (birthdayToCheck != today)
            {
                Console.WriteLine("its not your birthday today");
            }
            else
            {
                //Ascii art
                Console.WriteLine(".-..-. .--. .---. .---. .-..-.  .---. .-..---. .-----..-..-..---.  .--. .-..-.");
                Console.WriteLine(": :; :: .; :: .; :: .; :: :: :  : .; :: :: .; :`-. .-': :; :: .  :: .; :: :: :");
                Console.WriteLine(":    ::    ::  _.':  _.'`.  .'  :   .': ::   .'  : :  :    :: :: ::    :`.  .'");
                Console.WriteLine(": :: :: :: :: :   : :    .' ;   : .; :: :: :.`.  : :  : :: :: :; :: :: : .' ; ");
                Console.WriteLine(":_;:_;:_;:_;:_;   :_;   :_,'    :___.':_;:_;:_;  :_;  :_;:_;:___.':_;:_;:_,' ");
            }

            //Keep the console open
            Console.ReadLine();


            //Write new code here:


        }
    }
}
