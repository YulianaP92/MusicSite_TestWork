using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MusicSite.BLL.DTO;
using MusicSite.DAL.Entities;
using MusicSite.WEB.Models;
using Profile = AutoMapper.Profile;

namespace MusicSite.WEB.Infrastucture.MappingProfile
{
    public class AuthorMappingProfile : Profile
    {
        public AuthorMappingProfile()
        {
            MapAuthorViewModelToAuthorDTO();
            MapAuthorDTOToAuthorViewModel();
            MapAuthorToAuthorDTO();
            MapAuthorDTOToAuthor();
        }
        private void MapAuthorViewModelToAuthorDTO()
        {
            CreateMap<AuthorViewModel, AuthorDto>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, c => c.MapFrom(src => src.Name))
                .ForMember(dest => dest.SongsDto, c => c.MapFrom(src => src.SongsDto))
                .ForAllOtherMembers(c => c.Ignore());
        }
        private void MapAuthorDTOToAuthorViewModel()
        {
            CreateMap<AuthorDto, AuthorViewModel>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, c => c.MapFrom(src => src.Name))
                .ForMember(dest => dest.SongsDto, c => c.MapFrom(src => src.SongsDto))
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, c => c.MapFrom(src => src.Name))
                .ForAllOtherMembers(c => c.Ignore());
        }

        private void MapAuthorToAuthorDTO()
        {
            CreateMap<Author, AuthorDto>()
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, c => c.MapFrom(src => src.Name))
                .ForMember(dest => dest.SongsDto, c => c.MapFrom(src => src.Songs))              
                .ForAllOtherMembers(c => c.Ignore());
        }
        private void MapAuthorDTOToAuthor()
        {
            CreateMap<AuthorDto, Author>()
                .ForMember(dest => dest.Songs, c => c.MapFrom(src => src.SongsDto))
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, c => c.MapFrom(src => src.Name))
                .ForAllOtherMembers(c => c.Ignore());
        }

    }
}