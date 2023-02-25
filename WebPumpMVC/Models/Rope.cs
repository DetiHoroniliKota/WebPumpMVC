namespace WebPumpMVC.Models
{
    public class Rope
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public int Diameter { get; set; }

        public decimal Price { get; set; }

        public static implicit operator List<object>(Rope v)
        {
            throw new NotImplementedException();
        }
    }
}
