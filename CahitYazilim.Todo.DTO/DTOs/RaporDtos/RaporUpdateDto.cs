using System;
using System.Collections.Generic;
using System.Text;
using CahitYazilim.Todo.Entities.Concrete;

namespace CahitYazilim.Todo.DTO.DTOs.RaporDtos
{
    public class RaporUpdateDto
    {
        public int Id { get; set; }
        public string Tanim { get; set; }
        public string Detay { get; set; }
        public Gorev Gorev { get; set; }
        public int GorevId { get; set; }
    }
}
