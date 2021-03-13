using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleMarket.Model
{
    public class Video
    {
        public int Id { get; set; }
        public string LinkVideo { get; set; }

        // public virtual Multimedia Multimedia { get; set; }

        public virtual ICollection<Multimedia> Multimedia { get; set; }

    }
}
