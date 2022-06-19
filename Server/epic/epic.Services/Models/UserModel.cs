using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace epic.Services.Models
{
    public class UserModel
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        //[StringLength(255)]
        //public string Password { get; set; }
        //public string ConfirmPassword { get; set; }
        public bool IsActive { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }

        public int[] RoleIds { get; set; }
        public string[] Roles { get; set; }
    }
}
