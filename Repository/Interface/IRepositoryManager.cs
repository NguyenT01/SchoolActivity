namespace Repository.Interface
{
    public interface IRepositoryManager
    {
        public IClassroomRepository Classroom { get; }

        public Task Save();
    }
}
