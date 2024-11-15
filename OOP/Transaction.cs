using System;

namespace PracticeOOP
{
    public abstract class Transaction
    {
        public int ID { get; set; }
        public DateTime createdAt { get; set; }
        public double totalAmount { get; set; }
    }
}
