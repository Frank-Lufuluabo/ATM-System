using ATMSystem.Domain.Entities;
using ATMSystem.UI;

namespace ATMSystem.App
{
    class ATMSystem
    {
        private List<UserAccount> userAccountList;
        private UserAccount selectedAccount;

        public void InitializeData()
        {
            userAccountList = new List<UserAccount>
            {
                new UserAccount{Id=1, FullName = "Frank Lufuluabo", AccountNumber = 123456, CardNumber = 987987, CardPin = 123123, AccountBalance = 5000.00m, IsLocked = false },
                new UserAccount{Id=2, FullName = "Joe Smith", AccountNumber = 456789, CardNumber = 654654, CardPin = 456456, AccountBalance = 7000.00m, IsLocked = true },
            };
        }

        public void CheckUserCardNumAndPassword()
        {
            bool isCorrectionLogin = false;
            while (isCorrectionLogin == false)
            {
                UserAccount inputAcccount = AppScreen.UserLoginForm();
                AppScreen.LoginProgress();
                foreach (UserAccount account in userAccountList)
                {
                    selectedAccount = account;
                    if (inputAcccount.CardNumber.Equals(selectedAccount.CardNumber))
                    {
                        selectedAccount.TotalLogin++;

                        if (inputAcccount.CardPin.Equals(selectedAccount.CardPin)) 
                        {
                            selectedAccount = account;

                            if (!selectedAccount.IsLocked || selectedAccount.TotalLogin > 3)
                            {
                                AppScreen.PrintLockScreen();
                            }
                            else
                            {
                                selectedAccount.TotalLogin = 0;
                                isCorrectionLogin = true;
                                break;
                            }
                        }
                    }
                }
            }
            if (isCorrectionLogin == false) 
            {
                Utility.PrintMessage("\nInvalid card number or PIN.", false);
                selectedAccount.IsLocked = selectedAccount.TotalLogin == 3;
                if (selectedAccount.IsLocked)
                {
                    AppScreen.PrintLockScreen();
                }
            }
            Console.Clear();
        }

        public void Welcome()
        {
            Console.WriteLine($"Welcome back, {selectedAccount.FullName}");
        }
    }
}
