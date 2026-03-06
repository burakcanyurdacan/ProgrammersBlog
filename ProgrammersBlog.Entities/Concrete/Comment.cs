using ProgrammersBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Concrete
{
    public class Comment : EntityBase, IEntity
    {
        public string Text { get; set; }

        #region Navigation property => SQL'de tablo ilişkisi kurmak için

        //Bir yorumun 1 makaleye ait olduğunu diyoruz.
        public int ArticleId { get; set; }
        public Article Article { get; set; } 

        #endregion
    }
}