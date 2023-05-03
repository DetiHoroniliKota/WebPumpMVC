namespace WebPumpMVC.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string? PumpsTitle { get; set; }
        public string? RopeTitle { get; set; }
        public string? HydraulicAccumulatorTitle { get; set; }
        public string? ClampTitle { get; set; }
        public string? PipeTitle { get; set; }
        public string? CapTitle { get; set; }
        public string? UnderwaterСableTitle { get; set; }
        public string? AutomationTitle { get; set; }

        public int PumpId { get; set; }
        public int RopeId { get; set; }
        public int HydraulicAccumulatorId { get; set; }
        public int ClampId { get; set; }
        public int PipeId { get; set; }
        public int Capid { get; set; }
        public int UnderwaterСableId { get; set; }
        public int AutomationId { get; set; }

        public Automation? Automation { get; set; }
        public UnderwaterСable? UnderwaterСable { get; set; }
        public Cap? Cap { get; set; }
        public Pipe? Pipe { get; set; }
        public Clamp? Clamp { get; set; }
        public HydraulicAccumulator? HydraulicAccumulator { get; set; }
        public Pump? Pump { get; set; }
        public Rope? Rope { get; set; }
    }
}
