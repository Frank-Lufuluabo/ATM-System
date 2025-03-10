using ATMSystem.UI;

namespace ATMSystem.App
{
    public class Entry
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            ATMSystem atmSystem = new ATMSystem();

            atmSystem.CheckUserCardNumAndPassword();

            Utility.PressEnterToContinue();
        }
    }
}
