namespace WebPumpMVC.Servises
{
    public interface Irope
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public int Diameter { get; set; }

        public decimal Price { get; set; }
    }
}
