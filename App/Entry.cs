using ATMSystem.UI;

namespace ATMSystem.App
{
    public class Entry
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            long cardNumber = Validator.Convert<long>("Your card number");
            Console.WriteLine($"your Name is {cardNumber}");

            Utility.PressEnterToContinue();
        }
    }
}
