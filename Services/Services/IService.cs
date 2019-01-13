using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
  public  interface IService<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
       TEntity GetBuyId(int id);
        void Save(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
      //  IEnumerable<TEntity> GetByprop ();









    }
}
