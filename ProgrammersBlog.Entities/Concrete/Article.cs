using ProgrammersBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Concrete
{
    public class Article : EntityBase, IEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public DateTime Date { get; set; }
        public int ViewsCount { get; set; }
        public int CommentsCount { get; set; }
        public string SeoAuthor { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }

        #region Navigation property => SQL'de tablo ilişkisi kurmak için

        //Bir makalenin birden fazla yorumu olabilir diyoruz.
        public ICollection<Comment> Comments { get; set; }

        //Bir makaleyi paylaşan 1 kullanıcı ve makalenin 1 kategorisi olabilir diyoruz.
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int UserId { get; set; }
        public User User { get; set; } 

        #endregion
    }
}