using System;
using System.Data.SqlClient;

namespace PracticeOOP
{
    public class TransactionSave
    {
        private const string _cntString = @"Server=localhost;Database=WebDB;User Id=sa;Password=133M@yto;";

        public void SaveTransaction(Orders order)
        {
            using (SqlConnection connection = new SqlConnection(_cntString))
            {
                connection.Open();

                string query = "INSERT INTO Orders (customerID, totalAmount, orderStatus, paymentStatus, paymentMethodID, overdueDate) VALUES (@customerID, @totalAmount, @orderStatus, @paymentStatus, @paymentMethodID, @overdueDate)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@customerID", order.customerID);
                command.Parameters.AddWithValue("@totalAmount", order.totalAmount);
                command.Parameters.AddWithValue("@orderStatus", order.orderStatus);
                command.Parameters.AddWithValue("@paymentStatus", order.paymentStatus);
                command.Parameters.AddWithValue("@paymentMethodID", order.paymentMethodID);
                command.Parameters.AddWithValue("@overdueDate", order.overdueDate);

                command.ExecuteNonQuery();

                Console.WriteLine("Order saved.");
            }
        }

        public void SaveTransaction(ShoppingCart cart)
        {
            using (SqlConnection connection = new SqlConnection(_cntString))
            {
                string query = "INSERT INTO Carts (cartID, customerID, totalAmount, createdAt) VALUES (@cartID, @customerID, @totalAmount, @createdAt)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@cartID", cart.ID);
                command.Parameters.AddWithValue("@customerID", cart.customerID);
                command.Parameters.AddWithValue("@totalAmount", cart.totalAmount);
                command.Parameters.AddWithValue("@createdAt", cart.createdAt);

                connection.Open();
                command.ExecuteNonQuery();

                // Save Cart item
                foreach (var item in cart.items)
                {
                    string itemQuery = "INSERT INTO ShoppingCart (cartID, productID, quantity) VALUES (@cartID, @productID, @quantity)";

                    SqlCommand itemCommand = new SqlCommand(itemQuery, connection);
                    itemCommand.Parameters.AddWithValue("@cartID", cart.ID);
                    itemCommand.Parameters.AddWithValue("@productID", item.productID);
                    itemCommand.Parameters.AddWithValue("@quantity", item.quantity);

                    itemCommand.ExecuteNonQuery();
                }

                Console.WriteLine("Shopping cart saved.");
            }
        }
    }
}