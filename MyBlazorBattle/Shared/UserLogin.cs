using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorBattle.Shared
{
    public class UserLogin
    {
        [Required]
        public String Username { get; set; }
        [Required]
        public String Password { get; set; }

    }
}
