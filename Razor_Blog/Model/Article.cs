using System;

namespace Razor_Blog.Model
{
    public class Article
    {
        public Article(string title, string picture, string pictrueAlt, string pictureTitle, string shortDescription, string body)
        {
            Title = title;
            Picture = picture;
            PictrueAlt = pictrueAlt;
            PictureTitle = pictureTitle;
            ShortDescription = shortDescription;
            Body = body;
            CreationDate = DateTime.Now;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string PictrueAlt { get; set; }
        public string PictureTitle{ get; set; }
        public string ShortDescription { get; set; }
        public string Body { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }

    }
}
