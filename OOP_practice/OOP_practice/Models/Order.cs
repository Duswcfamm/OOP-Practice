public class Order : BaseEntity, ISaveable
{
    public User User { get; set; }
    public int UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public string OrderStatus { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public int PaymentMethodId { get; set; }
    public Shipping Shipping { get; set; }
    public int ShippingId { get; set; }
    public ICollection<OrderItem> OrderItems { get; set; }

    public void Save()
    {
        // Logic lưu vào bảng Order trong cơ sở dữ liệu
        Console.WriteLine("Lưu đơn hàng vào cơ sở dữ liệu");
    }
}