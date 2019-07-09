using System.Collections.Generic;

namespace MusicSite.DAL.Interfaces
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
    }
}
