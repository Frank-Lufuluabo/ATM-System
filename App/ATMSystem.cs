using ATMSystem.Domain.Entities;
using ATMSystem.UI;

namespace ATMSystem.App
{
    class ATMSystem
    {
        private List<UserAccount> userAccountList;
        private UserAccount selectedAccount;

        public void Initializedata()
        {
            userAccountList = new List<UserAccount>
            {
                new UserAccount{Id=1, FullName = "Frank Lufuluabo", AccountNumber = 123456, CardNumber = 987987, CardPin = 123123, AccountBalance = 5000.00m, IsLocked = false },
                new UserAccount{Id=2, FullName = "Joe Smith", AccountNumber = 456789, CardNumber = 654654, CardPin = 456456, AccountBalance = 7000.00m, IsLocked = true },
            };
        }

       
    }
}
