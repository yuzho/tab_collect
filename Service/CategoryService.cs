using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Domain;

namespace Service
{
    public class CategoryService : ICategoryService
    {
        private DwGuitarContext db = new DwGuitarContext();

        public IList<Category> GetAllCategories()
        {
            return db.Categorys.ToList();
        }
    }
}
