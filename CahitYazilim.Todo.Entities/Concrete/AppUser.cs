using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using CahitYazilim.Todo.Entities.Interfaces;

namespace CahitYazilim.Todo.Entities.Concrete
{
    public class AppUser : IdentityUser<int>, ITablo
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Picture { get; set; } = "default.png";


        public List<Bildirim> Bildirimler { get; set; }
        public List<Gorev> Gorevler { get; set; }
    }
}
