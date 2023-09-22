using OgrenciTakipSistemi.Business.Abstract;
using OgrenciTakipSistemi.DAL.Abstract;
using OgrenciTakipSistemi.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciTakipSistemi.Business.Concrete
{
    public class DersNotManager : BaseManager<DersNot>, IDersNotManager
    {
        public DersNotManager(IBaseRepository<DersNot> repository) : base(repository)
        {
        }
    }
    
}
