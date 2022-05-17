using BusinessLayer.Concrete;
using DataAccsessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogDal());
        public IActionResult Index()
        {
            var values = bm.GetList();
            return View(values);
        }
    }
}
