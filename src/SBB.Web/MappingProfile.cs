using AutoMapper;
using SBB.Core.Entities;

namespace SBB.Web;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDto>();        
    }
}
