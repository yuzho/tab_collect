using Data.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IBlogService
    {
        IList<Blog> GetBlogsByCategoryId(int categoryId);

        IList<Blog> GetBlogsBySearchText(string searchText);
    }
}
