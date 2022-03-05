using System;
using System.Collections.Generic;
using System.Text;
using CahitYazilim.Todo.Entities.Concrete;

namespace CahitYazilim.Todo.Business.Interfaces
{
    public interface IAppUserService
    {
        List<AppUser> GetirAdminOlmayanlar();
        List<AppUser> GetirAdminOlmayanlar(out int toplamSayfa, string aranacakKelime, int aktifSayfa = 1);
        List<DualHelper> GetirEnCokGorevTamamlamisPersoneller();
        List<DualHelper> GetirEnCokGorevdeCalisanPersoneller();
    }
}
