namespace WebPumpMVC.Models
{
    public class UnderwaterСable
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public double Section { get; set; }
        public decimal Price { get; set; }

        public ICollection<Equipment> Equipments { get; set; }
    }
}
