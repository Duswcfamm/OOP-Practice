using System;
using System.Data.SqlClient;

namespace PracticeOOP
{
    public class TransactionSave : ITransactionSave
    {
        private const string cntString = @"Server=localhost;Database=WebDB;User Id=sa;Password=133M@yto;";

        public void SaveTransaction(Transaction transaction)
        {
            using (SqlConnection cnt = new SqlConnection(cntString))
            {
                cnt.Open();
                transaction.UpdateDBTransaction(cnt);
                Console.WriteLine("Transaction saved.");
            }
        }
    }
}