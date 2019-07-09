using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicSite.WEB.Models;
using MusicSite.BLL.DTO;
using MusicSite.DAL.Entities;
using Profile = AutoMapper.Profile;

namespace MusicSite.WEB.Infrastucture.MappingProfile
{
    public class SongMappingProfile :Profile
    {
        public SongMappingProfile()
        {
            MapSongViewModelToSongDTO();
            MapSongDTOToSongViewModel();
            MapSongToSongDTO();
            MapSongDTOToSong();
        }
        private void MapSongViewModelToSongDTO()
        {
            CreateMap<SongViewModel, SongDto>()
                .ForMember(dest => dest.Name, c => c.MapFrom(src => src.Name))
                .ForMember(dest => dest.AuthorDto, c => c.MapFrom(src => src.Author))
                .ForMember(dest => dest.AuthorId, c => c.MapFrom(src => src.AuthorId))
                .ForMember(dest => dest.Genre, c => c.MapFrom(src => src.Genre))
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.PostedOnSite, c => c.MapFrom(src => src.PostedOnSite))
                .ForAllOtherMembers(c => c.Ignore());
        }
        private void MapSongDTOToSongViewModel()
        {
            CreateMap<SongDto, SongViewModel>()
                .ForMember(dest => dest.Author, c => c.MapFrom(src => src.AuthorDto))
                .ForMember(dest => dest.AuthorId, c => c.MapFrom(src => src.AuthorId))
                .ForMember(dest => dest.Genre, c => c.MapFrom(src => src.Genre))
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, c => c.MapFrom(src => src.Name))
                .ForMember(dest => dest.PostedOnSite, c => c.MapFrom(src => src.PostedOnSite))              
                .ForAllOtherMembers(c => c.Ignore());
        }

        private void MapSongToSongDTO()
        {
            CreateMap<Song, SongDto>()
                .ForMember(dest => dest.AuthorId, c => c.MapFrom(src => src.AuthorId))
                .ForMember(dest => dest.AuthorDto, c => c.MapFrom(src => src.Author))
                .ForMember(dest => dest.Genre, c => c.MapFrom(src => src.Genre))
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, c => c.MapFrom(src => src.Name))
                .ForMember(dest => dest.PostedOnSite, c => c.MapFrom(src => src.PostedOnSite))
                .ForAllOtherMembers(c => c.Ignore());
        }
        private void MapSongDTOToSong()
        {
            CreateMap<SongDto, Song>()
                .ForMember(dest => dest.AuthorId, c => c.MapFrom(src => src.AuthorId))
                .ForMember(dest => dest.Author, c => c.MapFrom(src => src.AuthorDto))
                .ForMember(dest => dest.Genre, c => c.MapFrom(src => src.Genre))
                .ForMember(dest => dest.Id, c => c.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, c => c.MapFrom(src => src.Name))
                .ForMember(dest => dest.PostedOnSite, c => c.MapFrom(src => src.PostedOnSite))
                .ForAllOtherMembers(c => c.Ignore());
        }
    }
}