using System;
using System.Collections.Generic;
using System.Text;
using CahitYazilim.Todo.Entities.Concrete;

namespace CahitYazilim.Todo.Business.Interfaces
{
    public interface IRaporService : IGenericService<Rapor>
    {
        Rapor GetirGorevileId(int id);
        int GetirRaporSayisiileAppUserId(int id);
        int GetirRaporSayisi();
    }
}
