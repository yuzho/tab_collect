using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Data.Domain;
namespace Service
{
    public interface ICategoryService
    {
        IList<Category> GetAllCategories();
    }
}
