using System.ComponentModel.DataAnnotations;

namespace WebPumpMVC.Models
{
    public class Pump
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public int H { get; set; }
        public int Q { get; set; }
        public decimal Price { get; set; }
    }
}
