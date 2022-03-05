using System;
using System.Collections.Generic;
using System.Text;
using CahitYazilim.Todo.DataAccess.Interfaces;
using CahitYazilim.Todo.Entities.Concrete;

namespace CahitYazilim.Todo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAciliyetRepository : EfGenericRepository<Aciliyet>, IAciliyetDal
    {
    }
}
