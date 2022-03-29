using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Models;

namespace DataAccessLayer.EntityFramework
{
    public class EfServiceDal : GenericRepository<Service>,IServiceDal
    {
        
    }
}