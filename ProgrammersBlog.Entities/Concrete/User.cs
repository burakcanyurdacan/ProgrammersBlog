using ProgrammersBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Concrete
{
    public class User : EntityBase, IEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Username { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }

        #region Navigation property => SQL'de tablo ilişkisi kurmak için

        //Bir kullanıcının birden fazla makalesi olabilir diyoruz.
        public ICollection<Article> Articles { get; set; }

        //Bir kullanıcının 1 rolü olabilir diyoruz.
        public int RoleId { get; set; }
        public Role Role { get; set; } 

        #endregion
    }
}