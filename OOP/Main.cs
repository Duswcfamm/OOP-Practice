using System;
using System.Collections.Generic;

namespace PracticeOOP
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            
            TransactionSave storage = new TransactionSave();

            Orders newOrder = new Orders
            {
                overdueDate = DateTime.Now.AddDays(7),
                createdAt = DateTime.Now,
                ID = 1,
                customerID = 123,
                totalAmount = 250.50,
                orderStatus = "pending",
                paymentStatus = "unpaid",
                paymentMethodID = 2
            };
            storage.SaveTransaction(newOrder);
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
            storage.SaveTransaction(cart);
        } 
    }
}
