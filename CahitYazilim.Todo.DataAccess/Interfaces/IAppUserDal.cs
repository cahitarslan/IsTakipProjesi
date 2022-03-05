using CahitYazilim.Todo.Entities.Concrete;
using System.Collections.Generic;

namespace CahitYazilim.Todo.DataAccess.Interfaces
{
    public interface IAppUserDal
    {
        List<AppUser> GetirAdminOlmayanlar();
        List<AppUser> GetirAdminOlmayanlar(out int toplamSayfa, string aranacakKelime, int aktifSayfa = 1);
        List<DualHelper> GetirEnCokGorevTamamlamisPersoneller();
        List<DualHelper> GetirEnCokGorevdeCalisanPersoneller();
    }
}
