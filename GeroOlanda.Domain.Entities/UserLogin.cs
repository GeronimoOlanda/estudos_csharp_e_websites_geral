using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GeroOlanda.Domain.Entities
{
    public class UserLogin
    {

        [Key]
        public int Id_Usuario { get; set; }

        public string UserName { get; set; }
        public string LoginUser { get; set; }
        public string Password { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public string Password_Encrypt { get; set; }
        public string flag_UserAlive { get; set; }
        public string flag_Setor { get; set; }

       
    }
}
