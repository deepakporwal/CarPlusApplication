using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Common
{
    public class UserModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string EmailAddress { get; set; }
    }
}
