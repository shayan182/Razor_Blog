using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Razor_Blog.Model;

namespace Razor_Blog.Pages
{
    public class IndexModel : PageModel
    {
        public List<ArticleViewModel> Articles { get; set; }
        private readonly BlogContext _context;

        public IndexModel(BlogContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Articles = _context.Articles
                .Where(x=>x.IsDeleted == false)
                .Select(x => new ArticleViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Picture = x.Picture,
                PictrueAlt = x.PictrueAlt,
                PictureTitle = x.PictureTitle,
                ShortDescription = x.ShortDescription
            })
                .OrderByDescending(x => x.Id)
                .ToList();
        }

        public IActionResult OnGetDelete(int id)
        {
            var article = _context.Articles.First(x=>x.Id == id);
            article.IsDeleted = true;
            _context.SaveChanges();
            return RedirectToPage("./Index");
        }
    }
}
