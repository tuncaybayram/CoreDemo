using DataAccsessLayer.Abstract;
using DataAccsessLayer.Repositories;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete.EntityFramework
{
    public class EfBlogDal:GenericRepository<Blog>,IBlogDal
    {

    }
}
