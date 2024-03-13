namespace DTO
{
    public record ClassroomDeleteDTO : ClassroomWithDateTimeDTO
    {

    }

    public record ClassroomWithDateTimeDTO
    {
        public string? ClassroomId { get; init; }
        public int Month { get; init; }
        public int Week { get; init; }
    }
}
