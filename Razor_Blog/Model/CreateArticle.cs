using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Razor_Blog.Model
{
    public class CreateArticle
    {
        [DisplayName("عنوان")]
        [Required(ErrorMessage = "پر کردن این فیلد اجباری است.")]
        public string Title { get; set; }
        [DisplayName("مسیر عکس")]
        [Required(ErrorMessage = "پر کردن این فیلد اجباری است.")]
        public string Picture { get; set; }
        [DisplayName("alt عکس")]
        public string PictureAlt { get; set; }
        [DisplayName("عنوان عکس")]
        public string PictureTitle { get; set; }
        [DisplayName("توضیحات کوتاه")]
        [Required(ErrorMessage = "پر کردن این فیلد اجباری است.")]
        public string ShortDescription { get; set; }
        [DisplayName("متن")]
        public string Body { get; set; }

    }
}
