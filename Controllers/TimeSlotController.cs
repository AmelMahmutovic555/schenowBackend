using LifeMap.Database;
using LifeMap.Model;
using Microsoft.AspNetCore.Mvc;

namespace LifeMap.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TimeSlotController(HabitsDbContext context) : ControllerBase
    {
        [HttpGet("all")]
        public ActionResult<List<TimeSlot>> ListAll()
        {
            var slot = context.timeSlots
                           .OrderByDescending(ts => ts.available)
                           .ToList();

            if (slot.Count == 0)
            {
                return NotFound("No available schedule slots.");
            }

            return Ok(slot);
        }

        [HttpPut("book/{date}/{from}/{to}")]
        public ActionResult<TimeSlot> BookSlot(DateOnly date, TimeOnly from, TimeOnly to, [FromBody] TimeSlot timeSlot)
        {
            var slot = context.timeSlots.FirstOrDefault(ts => ts.available == true && ts.date == date && ts.from == from && ts.to == to && from < to);

            if(slot == null)
            {
                return NotFound("Slot doesn't exist.");
            }

           
            slot.name = timeSlot.name;
            slot.email = timeSlot.email;
            slot.available = false;

            context.SaveChanges();

            return Ok("Successfully Booked!");
        }

        [HttpPost("add")]
        public ActionResult<TimeSlot> AddSlot([FromBody] TimeSlot timeSlot)
        {
            var slot = context.timeSlots.FirstOrDefault(ts => ts.date == timeSlot.date && ts.from == timeSlot.from && ts.to == timeSlot.to);

            if (slot != null)
            {
                return BadRequest("That schedule date already exists.");
            }

            if (timeSlot.from > timeSlot.to)
            {
                return BadRequest("Invalid time.");
            }


            var newSlot = new TimeSlot
            {
                date = timeSlot.date,
                from = timeSlot.from,
                to = timeSlot.to,
                available = true
            };

            context.timeSlots.Add(newSlot);

            context.SaveChanges();

            return Ok("Available date successfully added.");
        }
    }
}
