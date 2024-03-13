namespace Repository.ErrorModel
{
    public sealed class ClassroomNotFoundException : NotFoundException
    {
        public ClassroomNotFoundException(string classroomId, int month, int week) : base($"{classroomId} - M: {month} -W: {week} Not Found") { }
    }
}
