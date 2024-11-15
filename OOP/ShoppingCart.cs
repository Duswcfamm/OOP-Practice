using System.Collections.Generic;

namespace PracticeOOP
{
    public class ShoppingCart : Transaction 
    {
        public int customerID { get; set; }
        public List<CartProduct> items { get; set; } = new List<CartProduct>();
    }
}

