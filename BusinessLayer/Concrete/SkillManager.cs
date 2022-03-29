using System.Collections.Generic;
using DataAccessLayer.Abstract;
using EntityLayer.Models;

namespace BusinessLayer.Concrete
{
    public class SkillManager
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void TAdd(Skill t)
        {
            _skillDal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skillDal.Delete(t);
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetList();
        }

        public Skill TGetById(int id)
        {
            return _skillDal.GetById(id);
        }

        public void TUpdate(Skill t)
        {
            _skillDal.Update(t);
        }

     
    }
}