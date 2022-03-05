using System;
using System.Collections.Generic;
using System.Text;
using CahitYazilim.Todo.Entities.Concrete;

namespace CahitYazilim.Todo.DataAccess.Interfaces
{
    public interface IRaporDal : IGenericDal<Rapor>
    {
        Rapor GetirGorevileId(int id);
        int GetirRaporSayisiileAppUserId(int id);
        int GetirRaporSayisi();
    }
}
