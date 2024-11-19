using System;
using System.Collections.Generic;

namespace PracticeOOP
{
    public interface ITransactionSave
    {
        void SaveTransaction(Transaction transaction);
    }
}