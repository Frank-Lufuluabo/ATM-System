
using ATMSystem.Domain.Entities;

namespace ATMSystem.UI
{
    public static class AppScreen
    {
          internal static void Welcome()
        {
            // Clears the console screen
            Console.Clear();
            // Sets the title of the console Windows 
            Console.Title = "ATM System";
            // Sets the text color or background color to white
            Console.ForegroundColor = ConsoleColor.White;

            // Set the welcome message 
            Console.WriteLine("\n\n---------------------- Welcome to ATM System ----------------------\n\n");

            //Prompt the user to insert atm card
            Console.WriteLine("Please insert your ATM Card");
            Console.WriteLine("Note: Actual ATM machine will accept and validate a physical ATM card, read the card number and validate it.");

            Utility.PressEnterToContinue();
        }


        internal static UserAccount UserLoginForm()
        {
            UserAccount tempUserAccount = new UserAccount();

            tempUserAccount.CardNumber = Validator.Convert<long>("Your card number");
            tempUserAccount.CardPin = Convert.ToInt32(Utility.GetSecretInput("Enter your card PIN"));
            return tempUserAccount;
        }

        internal static void LoginProgress()
        {
            Console.WriteLine("\nChecking card number and PIN...");
            Utility.PrintDotAnimation();
        }

        internal static void PrintLockScreen() 
        {
            Console.Clear();
            Utility.PrintMessage("Your account is locked. Please go the nearest branch to unlock your account. Thank you.", true);
            Utility.PressEnterToContinue();
            Environment.Exit(1);
        }
    }
}
