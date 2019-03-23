using BRC.Derya.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRC.Derya.Business.Abstract
{
    public interface IIletisimService
    {
        List<Iletisim> GetAll();
        void Add(Iletisim iletisim);
        void Update(Iletisim iletisim);
        void Delete(int id);
        //ddd
    }
}
