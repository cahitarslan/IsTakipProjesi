using System;
using System.Collections.Generic;
using System.Text;
using CahitYazilim.Todo.Entities.Concrete;

namespace CahitYazilim.Todo.Business.Interfaces
{
    public interface IBildirimService : IGenericService<Bildirim>
    {
        List<Bildirim> GetirOkunmayanlar(int AppUserId);
        int GetirOkunmayanSayisiileAppUserId(int AppUserId);
    }
}
