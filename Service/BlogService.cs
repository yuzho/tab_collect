﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Domain;

namespace Service
{
    public class BlogService : IBlogService
    { 
        private DwGuitarContext db = new DwGuitarContext();

        public IList<Blog> GetBlogsByCategoryId(int categoryId)
        {
            var blogs = db.Categorys.FirstOrDefault(c => c.CategoryId == categoryId)?.Blogs;
            if (blogs != null)
                return blogs.ToList();
            else
                return new List<Blog>();
        }

        public IList<Blog> GetBlogsBySearchText(string searchText)
        {
            //检索标题
            return (from b in db.Blogs
                    where b.Title.Contains(searchText)
                    select b).ToList();

         }
    }
}
