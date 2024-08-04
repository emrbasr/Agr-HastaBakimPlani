using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Amac
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int AgriHastaBakimPlaniId { get; set; }
        public AgriHastaBakimPlani AgriHastaBakimPlani { get; set; }
    }
}
