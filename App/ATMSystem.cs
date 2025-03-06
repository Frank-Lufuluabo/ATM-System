using ATMSystem.UI;

namespace ATMSystem.App
{
    class ATMSystem
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            string cardNumber = Utility.GetUserInput("Your card number");
            Console.WriteLine($"your Name is {cardNumber}");

            Utility.PressEnterToContinue();
        }
    }
}
