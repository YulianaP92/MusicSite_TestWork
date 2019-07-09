using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSite.BLL.Interfaces
{
   public  interface IService<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
    }
}
