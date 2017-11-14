using BankingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingApp.Services
{
    public class CheckingAccountService
    {
        private ApplicationDbContext db;

        public CheckingAccountService(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public void CreateCheckingAccount(string firstName, string lastName, string userId, decimal initialBalance)
        {
            
            var accountNumber = (123456 + db.CheckingAccount.Count()).ToString().PadLeft(10, '0');
            var checkingAccount = new CheckingAccount { FirstName = firstName, LastName = lastName, AccountNumber = accountNumber, Balance = initialBalance, ApplicationUserId = userId };
            db.CheckingAccount.Add(checkingAccount);
            db.SaveChanges();
        }
    }
}