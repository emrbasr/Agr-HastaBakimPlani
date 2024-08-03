using Entities.Abstarct;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class AgriHastaBakimPlani:BaseEntity
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public string Neden { get; set; }
        public string TaniOlculeri { get; set; }
        public string Amac { get; set; }
        public string Degerlendirme { get; set; }
        public string Not { get; set; }

       
        public int HastaId { get; set; }
        public Hasta Hasta { get; set; }

        
        public int HemsireId { get; set; }
        public Hemsire Hemsire { get; set; }

        public List<Girisim> Girisimler { get; set; }
        public List<Sonuc> Sonuclar { get; set; }
    }
}