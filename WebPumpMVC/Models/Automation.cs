namespace WebPumpMVC.Models
{
    public class Automation
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public decimal Price { get; set; }
        public string? Typ { get; set; }

        
        public Order? Order { get; set; }
    }
}
