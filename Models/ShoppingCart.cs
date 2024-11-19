using System.Collections.Generic;
using System.Data.SqlClient;

namespace PracticeOOP
{
    public class ShoppingCart : Transaction 
    {
        public override void UpdateDBTransaction(SqlConnection cnt)
        {
            string query = "INSERT INTO Carts (cartID, customerID, totalAmount, createdAt) VALUES (@cartID, @customerID, @totalAmount, @createdAt)";
            using (SqlCommand cmd = new SqlCommand(query, cnt))
            {
                cmd.Parameters.AddWithValue("@cartID", ID);
                cmd.Parameters.AddWithValue("@customerID", customerID);
                cmd.Parameters.AddWithValue("@totalAmount", totalAmount);
                cmd.Parameters.AddWithValue("@createdAt", createdAt);

                cmd.ExecuteNonQuery();
            }

            foreach (var item in items)
            {
                string itemQr = "INSERT INTO ShoppingCartItems (cartID, productID, quantity) VALUES (@cartID, @productID, @quantity)";

                using (SqlCommand itemCmd = new SqlCommand(itemQr, cnt))
                {
                    itemCmd.Parameters.AddWithValue("@cartID", ID);
                    itemCmd.Parameters.AddWithValue("@productID", item.productID);
                    itemCmd.Parameters.AddWithValue("@quantity", item.quantity);

                    itemCmd.ExecuteNonQuery();
                }
            }
        }
        public int customerID { get; set; }
        public List<CartProduct> items { get; set; } = new List<CartProduct>();
    }
}

