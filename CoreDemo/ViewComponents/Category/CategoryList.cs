using BusinessLayer.Concrete;
using DataAccsessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EfCatagoryDal());

        public IViewComponentResult Invoke()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
