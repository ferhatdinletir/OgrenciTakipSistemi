using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.Entities.Authentication
{
    public class AppUser:IdentityUser
    {
        public string? TcNO { get; set; }
    }
}
