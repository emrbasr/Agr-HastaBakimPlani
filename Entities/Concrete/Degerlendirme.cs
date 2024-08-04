using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Degerlendirme
    {
        public int Id { get; set; }
        public int HastaId { get; set; }
        public Hasta Hasta { get; set; }
        public string? Tarih { get; set; }
        public string? Saat { get; set; }
        public string? DegerlendirmeDurumu { get; set; }
        public string? Not { get; set; }
    }
}
