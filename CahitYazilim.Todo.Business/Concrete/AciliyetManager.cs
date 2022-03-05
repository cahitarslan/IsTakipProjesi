using System;
using System.Collections.Generic;
using System.Text;
using CahitYazilim.Todo.Business.Interfaces;
using CahitYazilim.Todo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using CahitYazilim.Todo.DataAccess.Interfaces;
using CahitYazilim.Todo.Entities.Concrete;

namespace CahitYazilim.Todo.Business.Concrete
{
    public class AciliyetManager : IAciliyetService
    {
        private readonly IAciliyetDal _aciliyetDal;
        public AciliyetManager(IAciliyetDal aciliyetDal)
        {
            _aciliyetDal = aciliyetDal;
        }

        public List<Aciliyet> GetirHepsi()
        {
            return _aciliyetDal.GetirHepsi();
        }

        public Aciliyet GetirIdile(int id)
        {
            return _aciliyetDal.GetirIdile(id);
        }

        public void Guncelle(Aciliyet tablo)
        {
            _aciliyetDal.Guncelle(tablo);
        }

        public void Kaydet(Aciliyet tablo)
        {
            _aciliyetDal.Kaydet(tablo);
        }

        public void Sil(Aciliyet tablo)
        {
            _aciliyetDal.Sil(tablo);
        }
    }
}
