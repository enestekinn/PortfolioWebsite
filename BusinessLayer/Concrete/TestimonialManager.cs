using System.Collections.Generic;
using DataAccessLayer.Abstract;
using EntityLayer.Models;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager
    {
     
        ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TAdd(Testimonial t)
        {
            _testimonialDal.Insert(t);
        }

        public void TDelete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public Testimonial TGetById(int id)
        {
            return   _testimonialDal.GetById(id);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }   
    
}