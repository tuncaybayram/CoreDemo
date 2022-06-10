using BusinessLayer.Concrete;
using DataAccsessLayer.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentDal());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment f)
        {
            f.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            f.CommentStatus = true;
            f.BlogID = 2;
            cm.CommentAdd(f);
            return PartialView();
        }
        public PartialViewResult CommentListByBlog(int id)
        {
            var values =cm.GetList(id);
            return PartialView(values);
        }
    }
}
