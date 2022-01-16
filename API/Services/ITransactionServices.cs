using API.Models;
using System.Collections.Generic;

namespace BankApp.Services
{
    public interface ITransactionServices
    {
        public List<Transaction> TransactionsList();

        public List<Transaction> TransactionsList(bool state);

        public Transaction GetTransaction(int id);

        public Transaction CreateTransaction(Transaction transaction);

        public void DeleteTransaction(int id);
    }
}
