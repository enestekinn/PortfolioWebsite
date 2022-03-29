using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Models;

namespace DataAccessLayer.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>,IFeatureDal
    {
        
    }
}