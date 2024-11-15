
using System;

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
    }

}
