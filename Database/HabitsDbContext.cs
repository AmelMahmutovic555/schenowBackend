using LifeMap.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LifeMap.Database
{
    public class HabitsDbContext(DbContextOptions<HabitsDbContext> options) : DbContext(options)
    {

        public DbSet<TimeSlot> timeSlots { get; set; }

    }
}
