public class Cart : BaseEntity, ISaveable
{
    public User User { get; set; }
    public int UserId { get; set; }
    public decimal TotalAmount { get; set; }
    public ICollection<CartItem> CartItems { get; set; }

    public void Save()
    {
        // Logic lưu vào bảng Order trong cơ sở dữ liệu
        Console.WriteLine("Lưu đơn hàng vào cơ sở dữ liệu");
    }
}