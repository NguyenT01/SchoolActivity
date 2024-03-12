namespace DTO
{
    public class ClassroomUpdateDTO
    {
        public string? ClassroomId { get; set; }
        public uint Month { get; set; }
        public uint Week { get; set; }
        public uint ActivityPoints { get; set; }
        public uint MinusPoints { get; set; }
    }
}
