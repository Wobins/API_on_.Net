using API.Models;
using API.ViewsModels.Accounts;
using System.Collections.Generic;

namespace API.Services
{
    public interface IAccountServices
    {
        public List<Account> AccountsList();

        public List<Account> AccountsList(bool state);

        public Account GetAccount(int id);

        public Account AccountCreate(Account account);

        public void AccountDelete(int id);

        public Account AccountEdit(int id, AccountEdit_VM accountEdit_VM);
    }
}
