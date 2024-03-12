namespace DTO
{
    public record ClassroomDeleteDTO : ClassroomWithDateTimeDTO
    {

    }

    public record ClassroomWithDateTimeDTO
    {
        public string? ClassroomId { get; init; }
        public uint Month { get; init; }
        public uint Week { get; init; }
    }
}
