using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UsedCarsOnline.Models
{
    public class User : IdentityUser
    {
        [DisplayName("Name")]
        public string Name { get; set; }


        [DisplayName("Last Name")]
        public string LastName { get; set; }


        [DisplayName("Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

    }
}
