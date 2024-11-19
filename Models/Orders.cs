
using System;
using System.Data.SqlClient;

namespace PracticeOOP
{
    public class Orders : Transaction
    {
        public int customerID { get; set; }
        public string orderStatus { get; set; }
        public string paymentStatus { get; set; }
        public int paymentMethodID { get; set; }
        public string deliveryStatus { get; set; }
        public int shippingProviderID { get; set; }
        public DateTime overdueDate { get; set; }
        public DateTime? paidAt { get; set; }

        public override void UpdateDBTransaction(SqlConnection cnt)
        {
            string query = "INSERT INTO Orders (CustomerID, TotalAmount, OrderStatus, PaymentStatus, PaymentMethodID, OverDueDate, Paid_at, DeliveryStatus, ShippingProviderID) VALUES (@CustomerID, @TotalAmount, @OrderStatus, @PaymentStatus, @PaymentMethodID, @OverDueDate, @Paid_at, @DeliveryStatus, @ShippingProviderID)";
            using (SqlCommand cmd = new SqlCommand(query, cnt))
            {
                cmd.Parameters.AddWithValue("@CustomerID", customerID);
                cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);
                cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus);
                cmd.Parameters.AddWithValue("@PaymentMethodID", paymentMethodID);
                cmd.Parameters.AddWithValue("@OverDueDate", overdueDate);
                cmd.Parameters.AddWithValue("@Paid_at", paidAt ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DeliveryStatus", deliveryStatus);
                cmd.Parameters.AddWithValue("@ShippingProviderID", shippingProviderID);
                cmd.ExecuteNonQuery();
            }
        }
    }

}
