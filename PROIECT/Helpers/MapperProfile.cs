using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PROIECT.Models;
using System.Collections.Generic;
using WSS.Models.DTOs.AngajatDTOs;
using WSS.Models.DTOs.MagazinDTOs;
using WSS.Models.DTOs.PartieDTOs;
using WSS.Models.DTOs.ProdusDTOs;
using WSS.Models.DTOs.StatiuneDTOs;
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

            CreateMap<Partie, PartieDTO>();
            CreateMap<PartieDTO, Partie>()
                .ForMember(p => p.Id, opt =>
                    opt.MapFrom(src => new Guid()));
            CreateMap<PartieUpdateDTO, Partie>();

            CreateMap<Magazin, MagazinAngajatiDTO>()
                .ForMember(a => a.Angajati, opt => opt.MapFrom((src, dest, destMember, context) =>
                    src.Angajati.Select(a => context.Mapper.Map<AngajatDTO>(a)).ToList()));
            CreateMap<Magazin, MagazinDTO>();
            CreateMap<MagazinDTO, Magazin>()
                .ForMember(m => m.Id, opt =>
                    opt.MapFrom(src => new Guid()));


            CreateMap<Statiune, StatiuneDTO>();
            CreateMap<StatiuneDTO, Statiune>()
                .ForMember(s => s.Id, opt =>
                    opt.MapFrom(src => new Guid()));
            CreateMap<StatiuneUpdateDTO, Statiune>();
            CreateMap<Statiune, StatiunePartiiMagazineDTO>()
                .ForMember(p => p.Partii, opt => opt.MapFrom((src, dest, destMember, context) =>
                    src.Partii.Select(p => context.Mapper.Map<PartieDTO>(p)).ToList()))
                .ForMember(p => p.Magazine, opt => opt.MapFrom((src, dest, destMember, context) =>
                    src.Magazine.Select(p => context.Mapper.Map<MagazinDTO>(p)).ToList()));

            CreateMap<AngajatDTO, Angajat>();
            CreateMap<Angajat, AngajatDTO>();
            CreateMap<AngajatCreateDTO, Angajat>()
                .ForMember(a => a.Id, opt =>
                    opt.MapFrom(src => new Guid()));
            CreateMap<AngajatUpdateDTO, Angajat>();

            CreateMap<Produs, ProdusDTO>();
            CreateMap<ProdusUpdateDTO, Produs>();
            CreateMap<ProdusDTO, Produs>()
                .ForMember(p => p.Id, opt =>
                    opt.MapFrom(src => new Guid()));

            



        }
    }
}
