using AutoMapper;
using AB.Dtos;
using AB.Models;

namespace AB.Profiles {
    public class UsersProfile : Profile {
        public UsersProfile () {
            //Source -> Target
            CreateMap<User, UserReadDto> ();
            CreateMap<UserCreateDto, User> ();
            CreateMap<UserUpdateDto, User> ();
            CreateMap<User, UserUpdateDto> ();
        }

    }

}