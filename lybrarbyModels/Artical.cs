using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lybrarbyModels
{
    public class Artical
    {
        public int Id { get; set; }
        public string? Version { get; set; }
        public virtual Item? Items { get; set; } 
        public virtual List<Author>? Authors { get; set; }
        public virtual List<Magazine>? Magazines { get; set; }
    }
}
