using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lybrarbyModels
{
    public class Magazine
    {
        public int Id { get; set; }
        public string? ISBN { get; set; }
        public virtual List<Artical>? Articals { get; set; }
        public virtual List<Author>? Authors { get; set; }
    }
}
