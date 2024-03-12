namespace DTO
{
    public record ClassroomDTO
    {
        public string? ClassroomId { get; init; }
        public uint Month { get; init; }
        public uint Week { get; init; }
        public uint ActivityPoints { get; init; }
        public uint MinusPoints { get; init; }
    }

}
