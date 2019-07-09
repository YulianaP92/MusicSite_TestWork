using System.Collections.Generic;

namespace MusicSite.BLL.Interfaces
{
    public  interface IService<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
    }
}
