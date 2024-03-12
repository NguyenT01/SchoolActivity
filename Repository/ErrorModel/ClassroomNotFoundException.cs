namespace Repository.ErrorModel
{
    public sealed class ClassroomNotFoundException : NotFoundException
    {
        public ClassroomNotFoundException(string classroomId, uint month, uint week) : base($"{classroomId} - M: {month} -W: {week} Not Found") { }
    }
}
