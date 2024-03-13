namespace Repository.Entities
{
    public class Classroom
    {

        public string? ClassroomId { get; set; }

        public int Month { get; set; }

        public int Week { get; set; }

        public int ActivityPoints { get; set; }
        public int MinusPoints { get; set; }

    }
}
