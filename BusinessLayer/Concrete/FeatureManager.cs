using System.Collections.Generic;
using DataAccessLayer.Abstract;
using EntityLayer.Models;

namespace BusinessLayer.Concrete
{
    public class FeatureManager : IGenericService<Feature>
    {
        private IFeatureDal _featureDal;
        private IGenericService<Feature> _genericServiceImplementation;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature t)
        {
            _featureDal.Insert(t);
        }

        public void TDelete(Feature t)
        {
            _featureDal.Delete(t);
        }

        public void TUpdate(Feature t)
        {
            _featureDal.Update(t);
        }


        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public Feature TGetById(int id)
        {
            return _featureDal.GetById(id);
        }

        public List<Feature> TGetListByFilter()
        {
            throw new System.NotImplementedException();
        }
    }
}