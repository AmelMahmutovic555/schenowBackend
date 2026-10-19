namespace LifeMap.Model
{
    public class TimeSlot
    {
        public int id {  get; set; }
        public DateOnly date {  get; set; }

        public TimeOnly from { get; set; }

        public TimeOnly to {  get; set; }

        public bool? available { get; set; } = true;

        public string? name { get; set; }

        public string? email { get; set; }
    }
}
