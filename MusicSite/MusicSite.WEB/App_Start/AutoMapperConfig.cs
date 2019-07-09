using AutoMapper;
using MusicSite.WEB.Infrastucture.MappingProfile;

namespace MusicSite.WEB
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