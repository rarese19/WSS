using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PROIECT.Models;
using System.Collections.Generic;
using WSS.Models.DTOs.UserDTOs;

namespace WSS.Helpers
{
    public class MapperProfile: Profile
    {
        public MapperProfile()
        {
            var hasher = new PasswordHasher<User>();
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>()
                .ForMember(u => u.Id,
                    opt => opt.MapFrom(src => new Guid()));

            CreateMap<UserSignUpDTO, User>()
                .ForMember(u => u.Id, opt =>
                    opt.MapFrom(src => new Guid()))
                .ForMember(u => u.PasswordHash, opt =>
                    opt.MapFrom(src => hasher.HashPassword(null, src.Password)))
                .ForMember(u => u.LockoutEnabled, opt =>
                    opt.MapFrom(src => false))
                .ForMember(u => u.SecurityStamp, opt =>
                    opt.Ignore());
        }
    }
}
