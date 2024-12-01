using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    //uygulama kullanicilarinin bilgilerini tutan class
    public class AppUser : IdentityUser<int>
    {
        public string AppUserName { get; set; }
        public string AppUserSurname { get; set; }
        public string AppUserDistrict { get; set; }
        public string AppUserCity { get; set; }
        public string AppUserImageUrl { get; set; }
    }
}