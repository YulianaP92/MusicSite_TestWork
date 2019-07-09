using Ninject.Modules;
using MusicSite.BLL.DTO;
using MusicSite.BLL.Interfaces;
using MusicSite.BLL.Services;

namespace MusicSite.WEB.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IService<SongDto>>().To<SongService>();
        }
    }
}