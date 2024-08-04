using Entities.Abstarct;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Hasta:BaseEntity
{
    
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string? Tani { get; set; }
    public string? Tanim { get; set; }
    public string? HemsireTanisi { get; set; }
    public DateTime? DogumTarihi { get; set; }
    public List<Degerlendirme>? Degerlendirmeler { get; set; }
    public ICollection<AgriHastaBakimPlani> AgriHastaBakimPlanlari { get; set; }
}
