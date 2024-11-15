using System;
using System.Collections.Generic;

namespace PracticeOOP
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            
            TransactionSave storage = new TransactionSave();
// test
            Orders newOrder = new Orders
            {
                overdueDate = DateTime.Now.AddDays(10),
                createdAt = DateTime.Now,
                ID = 1,
                customerID = 1,
                totalAmount = 1,
                orderStatus = "packaging",
                paymentStatus = "unpaid",
                paymentMethodID = 1
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
