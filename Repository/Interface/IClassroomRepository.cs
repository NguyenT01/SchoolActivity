using Repository.Entities;

namespace Repository.Interface
{
    public interface IClassroomRepository
    {
        public Task<IEnumerable<Classroom>> GetClassroomHistory(string classroomId, bool tracking);
        public Task<Classroom> GetClassroomByTime(string classroomId, uint month, uint week, bool tracking);
        public void CreateClassroom(Classroom classroom);
        public void DeleteClassroom(Classroom classroom);
    }
}
