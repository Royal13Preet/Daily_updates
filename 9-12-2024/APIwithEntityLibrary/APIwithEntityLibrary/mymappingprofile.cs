using AutoMapper;
using Microsoft.EntityFrameworkCore.Storage;
using APIwithEntityLibrary.Models;
using APIwithEntityLibrary.ViewModels;


namespace APIwithEntityLibrary
{
    public class mymappingprofile : Profile
    {
        public mymappingprofile()
        {

            //DB to VM
            CreateMap<Book, Bookdto>()
                .ForMember(x => x.AuthorName, x=> x.MapFrom(y=> y.author.AuthorName))
                .ReverseMap();

            CreateMap<Bookdto, Book>();

            //CreateMap<Models.Book, ViewModels.Bookdto>();

            CreateMap<Author, AuthorDto>().ReverseMap();
            

            CreateMap<Category, CategoryDto>().ReverseMap();


            //CreateMap<ViewModels.Bookdto, Models.Book>();

            CreateMap<User, userDto>()
            .ForMember(x => x.Password, x => x.Ignore());

            //VM to DM
            CreateMap<userDto, User>();

           


        }

    }
}
