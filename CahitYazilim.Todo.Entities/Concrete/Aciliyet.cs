using CahitYazilim.Todo.Entities.Interfaces;
using System.Collections.Generic;

namespace CahitYazilim.Todo.Entities.Concrete
{
    public class Aciliyet: ITablo
    {
        public int Id { get; set; }
        public string Tanim { get; set; }

        public List<Gorev> Gorevler { get; set; }
    }
}
