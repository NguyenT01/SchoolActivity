using AutoMapper;
using DTO;
using Repository.Entities;
using Repository.ErrorModel;
using Repository.Interface;
using Services.Interface;

namespace Services
{
    public class ClassroomService : IClassroomService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public ClassroomService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<ClassroomDTO> CreateClassroom(ClassroomCreationDTO classroom)
        {
            var classroomDB = _mapper.Map<Classroom>(classroom);
            _repositoryManager.Classroom.CreateClassroom(classroomDB);
            await _repositoryManager.Save();

            var classroomDto = _mapper.Map<ClassroomDTO>(classroomDB);
            return classroomDto;
        }

        public async Task DeleteClassroom(ClassroomDeleteDTO classroom, bool tracking)
        {
            var classroomDateTimeDTO = _mapper.Map<ClassroomWithDateTimeDTO>(classroom);
            var classroomDB = await _checkClassroomIfExists(classroomDateTimeDTO, tracking);

            _repositoryManager.Classroom.DeleteClassroom(classroomDB);
            await _repositoryManager.Save();
        }

        public async Task<ClassroomDTO> GetClassroomByTime(string cid, int month, int week, bool tracking)
        {
            var classroomDTO = new ClassroomWithDateTimeDTO
            {
                ClassroomId = cid,
                Month = month,
                Week = week
            };
            var classroom = await _checkClassroomIfExists(classroomDTO, tracking);
            var classroomDto = _mapper.Map<ClassroomDTO>(classroom);
            return classroomDto;
        }

        public async Task<IEnumerable<ClassroomDTO>> GetClassroomHistory(string classroomId, bool tracking)
        {
            var classrooms = await _repositoryManager.Classroom.GetClassroomHistory(classroomId, tracking);
            var classroomDto = _mapper.Map<IEnumerable<ClassroomDTO>>(classrooms);
            return classroomDto;
        }

        public async Task UpdateClassroom(ClassroomUpdateDTO classroom, bool tracking)
        {
            var classroomWithDateTimeDTO = _mapper.Map<ClassroomWithDateTimeDTO>(classroom);
            var classroomDB = await _checkClassroomIfExists(classroomWithDateTimeDTO, tracking);

            _mapper.Map(classroom, classroomDB);
            await _repositoryManager.Save();
        }

        #region Private methods
        private async Task<Classroom> _checkClassroomIfExists(ClassroomWithDateTimeDTO classroomDTO, bool tracking)
        {
            var classroom = await _repositoryManager.Classroom.GetClassroomByTime(classroomDTO.ClassroomId!, classroomDTO.Month,
                classroomDTO.Week, tracking);

            if (classroom is null)
                throw new ClassroomNotFoundException(classroomDTO.ClassroomId!, classroomDTO.Month,
                                classroomDTO.Week);
            return classroom;
        }

        #endregion
    }
}
