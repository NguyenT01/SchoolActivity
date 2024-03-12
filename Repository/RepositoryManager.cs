using Repository.Interface;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _context;
        private readonly IClassroomRepository _classroomRepository;

        public RepositoryManager(RepositoryContext context)
        {
            _context = context;
            _classroomRepository = new ClassroomRepository(context);
        }

        public IClassroomRepository Classroom => _classroomRepository;

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
