namespace DTO
{
    public record ClassroomDTO
    {
        public string? ClassroomId { get; init; }
        public int Month { get; init; }
        public int Week { get; init; }
        public int ActivityPoints { get; init; }
        public int MinusPoints { get; init; }
    }

}
