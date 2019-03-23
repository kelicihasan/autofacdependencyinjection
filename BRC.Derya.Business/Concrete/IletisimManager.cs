using BRC.Derya.Business.Abstract;
using BRC.Derya.DataAccsess.Abstract;
using BRC.Derya.DataAccsess.Concrete;
using BRC.Derya.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRC.Derya.Business.Concrete
{
    public class IletisimManager : IIletisimService
    {
        private IIletisimDal _iletisimDal;
        public IletisimManager(IIletisimDal iletisimDal)
        {
            iletisimDal = _iletisimDal;
        }
        public void Add(Iletisim iletisim)
        {
            _iletisimDal.Add(iletisim);
        }

        public void Delete(int id)
        {
            _iletisimDal.Delete(new Iletisim {
                id = id
            });
        }

        public List<Iletisim> GetAll()
        {
            return _iletisimDal.GetList();
        }

        public void Update(Iletisim iletisim)
        {
            _iletisimDal.Update(iletisim);
        }
    }
}
