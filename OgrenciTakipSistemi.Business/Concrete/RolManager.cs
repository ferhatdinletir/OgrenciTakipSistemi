using OgrenciTakipSistemi.Business.Abstract;
using OgrenciTakipSistemi.DAL.Abstract;
using OgrenciTakipSistemi.DAL.Concrete;
using OgrenciTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.Business.Concrete
{
    public class RolManager : BaseManager<Rol>, IRoleManager
    {
        //private readonly IRolRepository repository;

        public RolManager(IBaseRepository<Rol> repository) : base(repository)
        {
            //this.repository = repository
        }
    }
}
