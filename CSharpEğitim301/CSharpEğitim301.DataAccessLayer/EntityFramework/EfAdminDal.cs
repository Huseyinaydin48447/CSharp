using CSharpEğitim301.DataAccessLayer.Abstract;
using CSharpEğitim301.DataAccessLayer.Repositories;
using CSharpEğitim301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEğitim301.DataAccessLayer.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>, IAdminDal
    {
    }
}
