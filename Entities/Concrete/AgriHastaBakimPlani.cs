using Entities.Abstarct;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete
{
    public class AgriHastaBakimPlani:BaseEntity
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime Saat { get; set; }
        public string Not { get; set; }

       
        public int HastaId { get; set; }
        public Hasta Hasta { get; set; }

        
        public int HemsireId { get; set; }
        public Hemsire Hemsire { get; set; }

        public List<Girisim> Girisimler { get; set; }
        public List<Neden> Nedenler { get; set; }
        public ICollection<TaniOlculeri> TaniOlculeriList { get; set; }
        public ICollection<Amac> Amaclar { get; set; }
        public ICollection<Degerlendirme> Degerlendirmeler { get; set; }
        public List<CheckboxItem> DegerlendirmeItems { get; set; } = new List<CheckboxItem>();
        public List<Sonuc> Sonuclar { get; set; } = new List<Sonuc>();

    }
}