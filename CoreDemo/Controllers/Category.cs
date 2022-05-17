using BusinessLayer.Concrete;
using DataAccsessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class Category : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCatagoryDal());
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
