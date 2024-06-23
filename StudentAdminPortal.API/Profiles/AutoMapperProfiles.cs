using AutoMapper;
using StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.Profiles.AfterMaps;

namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Student, StudentDto>()
                .ReverseMap();
            CreateMap<Address, AddressDto>()
                .ReverseMap();
            CreateMap<Gender, GenderDto>()
                .ReverseMap();
            CreateMap<UpdateStudentRequestDto, Student>()
                .AfterMap<UpdateStudentRequestAfterMap>();

            CreateMap<AddStudentRequestDto, Student>()
                .AfterMap<AddStudentRequestAfterMap>();
        }
    }
}
