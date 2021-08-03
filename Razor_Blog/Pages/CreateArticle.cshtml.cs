using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Blog.Model;

namespace Razor_Blog.Pages
{
    public class CreateArticleModel : PageModel
    {
        private readonly BlogContext _context;

        public CreateArticleModel(BlogContext context)
        {
            _context = context;
        }

        public CreateArticle CreateArticle { get; set; }
        public void OnGet()
        {
        }

        public void OnPost(CreateArticle createArticle)
        {
            if (ModelState.IsValid)
            {
            var article = new Article(createArticle.Title, createArticle.Picture, createArticle.PictureAlt,
                createArticle.PictureTitle, createArticle.ShortDescription, createArticle.Body);
            _context.Articles.Add(article);
            _context.SaveChanges();
                
            }

        }
    }
}
