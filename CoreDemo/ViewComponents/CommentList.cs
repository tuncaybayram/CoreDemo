using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    UserName="Tuncay"
                },
                new UserComment
                {
                    ID=2,
                    UserName="Kutluhan"
                },new UserComment
                {
                    ID=3,
                    UserName="Merve"
                }
            };
            return View(commentValues);
        }

    }
}
