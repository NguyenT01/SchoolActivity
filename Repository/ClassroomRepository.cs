using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using Repository.Interface;

namespace Repository
{
    public class ClassroomRepository : RepositoryBase<Classroom>, IClassroomRepository
    {
        public ClassroomRepository(RepositoryContext context) : base(context) { }

        public void CreateClassroom(Classroom classroom)
            => Add(classroom);

        public void DeleteClassroom(Classroom classroom)
            => Delete(classroom);

        public async Task<Classroom> GetClassroomByTime(string classroomId, uint month, uint week, bool tracking)
            => await FindByCondition(c => c.ClassroomId!.Equals(classroomId) && c.Month == month && c.Week == week, tracking)
                    .SingleOrDefaultAsync();

        public async Task<IEnumerable<Classroom>> GetClassroomHistory(string classroomId, bool tracking)
            => await FindByCondition(c => c.ClassroomId!.Equals(classroomId), tracking)
                .OrderBy(c => c.Month)
                .ThenBy(c => c.Week)
                .ToListAsync();
    }
}
