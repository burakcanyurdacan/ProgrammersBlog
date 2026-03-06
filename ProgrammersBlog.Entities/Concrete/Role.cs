using ProgrammersBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Concrete
{
    public class Role : EntityBase, IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        #region Navigation property => SQL'de tablo ilişkisi kurmak için

        //Bir rolün birden fazla kullanıcısı olabilir diyoruz.
        public ICollection<User> Users { get; set; } 

        #endregion
    }
}