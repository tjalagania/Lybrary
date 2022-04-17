using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lybrarbyModels
{
    public class Book
    {
        public int Id { get; set; }
        public virtual Item? Item{get;set;}
        public string? ISBN { get; set; }
        public virtual List<Author>? Authros { get; set; }
    }
}
