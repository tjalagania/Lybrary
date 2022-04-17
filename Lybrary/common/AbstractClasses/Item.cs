using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.common
{
    public abstract class Item
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Publisher { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}
