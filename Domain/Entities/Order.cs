namespace Domain.Entities;

public class Order
{
    public int Id { get; set; }
    public TimeSpan OrderPlaces { get; set; }
    public TimeSpan OrderFullfilled { get; set; }
    public virtual Product Product { get; set; }
    public virtual ICollection<Product> Products { get; set; }
}