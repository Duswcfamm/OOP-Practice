public class Shop : BaseEntity
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public User CreatedUser { get; set; }
    public ICollection<Item> Items { get; set; }
}
