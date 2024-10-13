using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface ICategoriRepository
    {
        void Add(CategoriModel categoriModel);
        void Edit(CategoriModel categoriModel);
        void Delete(int id);
        IEnumerable<CategoriModel> GetAll();
        IEnumerable<CategoriModel> GetByValue(string value);

    }
}
