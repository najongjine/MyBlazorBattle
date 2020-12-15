using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazorBattle.Shared
{
    public class UserRegister
    {
        [Required,EmailAddress]
        public string Email { get; set; }
        [StringLength(16)]
        public string Username { get; set; }
        public string Bio { get; set; }
        [Required,StringLength(100,MinimumLength =6)]
        public string Password { get; set; }
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Range(0, 1000)]
        public int Bananas { get; set; } = 100;
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        [Range(typeof(bool), "true", "true", ErrorMessage = "only confirmed users can play")]
        public bool IsConfirmed { get; set; } = true;
        public string StartUnitId { get; set; }
    }
}
