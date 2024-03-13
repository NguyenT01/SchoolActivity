namespace DTO
{
    public class ClassroomDTO
    {
        public string? ClassroomId { get; init; }
        public int Month { get; init; }
        public int Week { get; init; }
        public int ActivityPoints { get; init; }
        public int MinusPoints { get; init; }
    }

    public class ClassroomWeeklyGradingDTO : ClassroomDTO
    {
        public string? Grading { get; set; }
    }

}
