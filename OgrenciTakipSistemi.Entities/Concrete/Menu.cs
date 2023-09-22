using OgrenciTakipSistemi.Entities.Abstract;
using OgrenciTakipSistemi.Entities.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.Entities.Concrete
{
    public class Menu : BaseEntity
    {
        public string MenuName { get; set; }
        public string? Area { get; set; }
        public string? Controller { get; set; }
        public string? Action { get; set; }
        public string? Css { get; set; }
        public string? Icon { get; set; }

        public string? IdentityRoleID { get; set; }
        public AppRole? Role { get; set; }
    }
}
