using System;
using System.Collections.Generic;

namespace PracticeOOP
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            
            ITransactionSave tempData = new TransactionSave();

            Orders newOrder = new Orders
            {
                overdueDate = DateTime.Now.AddDays(10),
                createdAt = DateTime.Now,
                ID = 1,
                customerID = 1,
                totalAmount = 1,
                orderStatus = "waiting",
                paymentStatus = "unpaid",
                paymentMethodID = 2
            };
            tempData.SaveTransaction(newOrder);
            ////////////////////////////////////
            ShoppingCart cart = new ShoppingCart
            {
                createdAt = DateTime.Now,
                ID = 1,
                customerID = 1,
                totalAmount = 10,
                items = new List<CartProduct>
            {
                new CartProduct {
                    productID = 1, 
                    quantity = 2 
                },
                new CartProduct {
                    productID = 2, 
                    quantity = 1 
                }
            }
            };
            tempData.SaveTransaction(cart);
        } 
    }
}
