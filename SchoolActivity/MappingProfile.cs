using AutoMapper;
using DTO;
using Repository.Entities;

namespace SchoolActivity
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Classroom, ClassroomDTO>();
            CreateMap<ClassroomCreationDTO, Classroom>();
            CreateMap<ClassroomDeleteDTO, Classroom>();
            CreateMap<ClassroomDeleteDTO, ClassroomWithDateTimeDTO>();
            CreateMap<ClassroomUpdateDTO, ClassroomWithDateTimeDTO>();

            CreateMap<ClassroomUpdateDTO, Classroom>()
                .ForMember(d => d.ActivityPoints, opts =>
                {
                    opts.MapFrom(s => s.ActivityPoints >= 0);
                })
                .ForMember(d => d.MinusPoints, opts => opts.MapFrom(s => s.MinusPoints >= 0));
        }
    }
}
