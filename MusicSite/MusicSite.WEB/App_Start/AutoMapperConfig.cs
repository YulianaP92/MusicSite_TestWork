using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MusicSite.WEB.Infrastucture.MappingProfile;

namespace MusicSite.WEB.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.Initialize(c =>
            {
                c.AddProfile(typeof(AuthorMappingProfile));
                c.AddProfile(typeof(SongMappingProfile));
            });
        }
    }
}