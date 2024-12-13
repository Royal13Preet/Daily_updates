using AutoMapper;
using Secureuser.Models.DBModels;
using Secureuser.Models.ViewModel;

namespace Secureuser.UserProject
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {
            CreateMap<User, UserCreatedto>().ReverseMap();
        }
    }
}
