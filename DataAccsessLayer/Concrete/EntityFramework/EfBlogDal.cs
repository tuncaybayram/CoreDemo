using DataAccsessLayer.Abstract;
using DataAccsessLayer.Repositories;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete.EntityFramework
{
    public class EfBlogDal : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using (var c =new Context())
            {
                return c.Blogs.Include(x => x.Category).ToList();
            }
             
        }
    }
}
