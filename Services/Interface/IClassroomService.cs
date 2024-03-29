﻿using DTO;

namespace Services.Interface
{
    public interface IClassroomService
    {
        public Task<IEnumerable<ClassroomDTO>> GetClassroomHistory(string classroomId, bool tracking);
        public Task<ClassroomDTO> GetClassroomByTime(string cid, int month, int week, bool tracking);
        public Task<ClassroomDTO> CreateClassroom(ClassroomCreationDTO classroom);
        public Task DeleteClassroom(ClassroomDeleteDTO classroom, bool tracking);
        public Task UpdateClassroom(ClassroomUpdateDTO classroom, bool tracking);

        public Task<ClassroomWeeklyGradingDTO> ClassroomGradingByWeek(string cid, int month, int week, bool tracking);

    }
}
