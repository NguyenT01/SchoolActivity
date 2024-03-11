using System.ComponentModel.DataAnnotations;

namespace Repository.Entities
{
    public class Classroom
    {
        [Key]
        public string? ClassroomId { get; set; }
        [Key]
        public uint Month { get; set; }
        [Key]
        public uint Week { get; set; }

        public uint ActivityPoints { get; set; }
        public uint MinusPoints { get; set; }

    }
}
