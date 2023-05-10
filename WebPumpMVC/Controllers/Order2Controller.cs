using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebPumpMVC.Data;
using WebPumpMVC.Models;

namespace WebPumpMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Order2Controller : ControllerBase
    {
        private readonly WebPumpMVCContext _context;

        private Order2Controller(WebPumpMVCContext context)
        {
            _context = context;
        }
        public IActionResult CreateOrders(string searchString)
        {
            var orderDetails = (from order in _context.Order
                                join pump in _context.Pump on
                                order.PumpId equals pump.Id
                                join automation in _context.Automation on
                                order.AutomationId equals automation.Id
                                join clamp in _context.Clamp on
                                order.ClampId equals clamp.Id
                                join hydraulicAccumulator in _context.HydraulicAccumulator on
                                order.HydraulicAccumulatorId equals hydraulicAccumulator.Id
                                join pipe in _context.Pipe on
                                order.PipeId equals pipe.Id
                                join rope in _context.Rope on
                                order.RopeId equals rope.Id
                                join underwaterСable in _context.UnderwaterСable on
                                order.UnderwaterСableId equals underwaterСable.Id
                                join cap in _context.Cap on
                                order.Capid equals cap.Id
                                where pump.Title == searchString
                                select new Order
                                {
                                    PumpsTitle = pump.Title,
                                    AutomationTitle = automation.Title,
                                    ClampTitle = clamp.Title,
                                    HydraulicAccumulatorTitle = hydraulicAccumulator.Title,
                                    PipeTitle = pipe.Title,
                                    RopeTitle = rope.Title,
                                    UnderwaterСableTitle = underwaterСable.Title,
                                    CapTitle = cap.Title
                                }).ToList();
            return Ok(orderDetails);
                           
        }


    }
}
