namespace WebPumpMVC.Models
{
    public class HydraulicAccumulator
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Volume { get; set; }
        public decimal Price { get; set; }
        public string? Typ { get; set; }

        public ICollection<Equipment> Equipments { get; set; }
    }
}
