using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lybrarbyModels
{
    public class Copy
    {
        public int Id { get; set; } 
        public virtual Item? Item { get; set; }
    }
}
