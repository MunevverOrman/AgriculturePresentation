using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Delete(About t)
        {
            throw new System.NotImplementedException();
        }

        public About GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<About> GetListAll()
        {
            return _aboutDal.GetListAll();
        }

        public void Insert(About t)
        {
            throw new System.NotImplementedException();
        }

        public void Update(About t)
        {
            throw new System.NotImplementedException();
        }
    }
}
