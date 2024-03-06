using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace mvc.Models
{
    public class User : IdentityUser
    {
        public ICollection<Playlist>? MyProperty { get; set; }

    }
}