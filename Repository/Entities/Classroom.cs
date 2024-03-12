using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Entities
{
    public class Classroom
    {
        [Key]
        [Column(Order = 0)]
        public string? ClassroomId { get; set; }
        [Key]
        [Column(Order = 1)]
        public uint Month { get; set; }
        [Key]
        [Column(Order = 2)]
        public uint Week { get; set; }

        public uint ActivityPoints { get; set; }
        public uint MinusPoints { get; set; }

    }
}
