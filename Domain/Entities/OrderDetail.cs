﻿namespace Domain.Entities;

public class OrderDetail
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    
    public int OrderId { get; set; }
    public virtual Order Order { get; set; }
    public virtual ICollection<Order> Orders { get; set; }
    
    public int ProductId { get; set; }
    public virtual Product Product { get; set; }
    public virtual ICollection<Product> Products { get; set; }
}