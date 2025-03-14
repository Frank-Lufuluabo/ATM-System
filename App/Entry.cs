using ATMSystem.UI;

namespace ATMSystem.App
{
    public class Entry
    {
        static void Main(string[] args)
        {
            ATMSystem atmSystem = new ATMSystem();
            atmSystem.InitializeData();
            atmSystem.Run();
        }
    }
}
