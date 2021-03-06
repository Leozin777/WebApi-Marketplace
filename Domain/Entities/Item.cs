using Domain.Entities;

namespace Domain.Entities
{
    public class Item
    {
        public int Id { get; set; } 
        public int Amount { get; set; } 
        public double Price { get; set; } 
         public bool Missing { get; set; }
        public Request Request { get; set; } 
        public int RequestId { get; set; } 
        public List<Product> Products { get; set; }

    }
}