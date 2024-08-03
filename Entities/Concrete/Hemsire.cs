using Entities.Abstarct;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Hemsire:BaseEntity
    {
        
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public ICollection<AgriHastaBakimPlani> AgriHastaBakimPlanlari { get; set; }
    }
}
