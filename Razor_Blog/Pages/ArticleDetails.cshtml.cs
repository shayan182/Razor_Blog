using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_Blog.Model;

namespace Razor_Blog.Pages
{
    public class ArticleDetailsModel : PageModel
    {
        public ArticleViewModel Articles { get; set; }
        private readonly BlogContext _context;

        public ArticleDetailsModel(BlogContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            Articles = _context.Articles.Select(x => new ArticleViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Picture = x.Picture,
                PictrueAlt = x.PictrueAlt,
                PictureTitle = x.PictureTitle,
                Body = x.Body,
                CreationDate = x.CreationDate.ToString()
            })
                .FirstOrDefault(x => x.Id == id);
        }
    }
}
