namespace WebPumpMVC.Models
{
    public class Pipe
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Diameter { get; set; }
        public decimal Price { get; set; }

        public ICollection<Equipment> Equipments { get; set; }
    }
}
