using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Girisim
    {
        public int Id { get; set; }
        public int AgriHastaBakimPlaniId { get; set; }
        public string Description { get; set; }

        public AgriHastaBakimPlani AgriHastaBakimPlani { get; set; }
    }
}
