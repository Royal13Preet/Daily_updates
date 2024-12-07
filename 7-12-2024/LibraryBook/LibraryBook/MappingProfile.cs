using AutoMapper;

namespace LibraryBook
{
    public class MappingProfile : Profile
    {
        public MappingProfile() {




            CreateMap<Models.Book, ViewModels.BookDto>()
                .ForMember(x => x.AuthorName, x => x.MapFrom(y => y.Author.AuthorName)).ReverseMap();

            CreateMap<ViewModels.BookDto, Models.Book>();

            CreateMap<Models.Author, ViewModels.AuthorDto>().ReverseMap();

            CreateMap<ViewModels.AuthorDto,Models.Author>();
        
        }
    }
}
