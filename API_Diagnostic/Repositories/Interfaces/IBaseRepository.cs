using API_Diagnostic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Diagnostic.Repositories.Interfaces
{
    public interface IBaseRepository<TDbModel> where TDbModel : BaseModel
    {
        List<TDbModel> GetAll();
        TDbModel Get(Guid id);
        TDbModel Create(TDbModel model);
        TDbModel Update(TDbModel model);
        void Delete(Guid id);
    }
}
