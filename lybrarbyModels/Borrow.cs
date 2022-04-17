using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lybrarbyModels
{
    public class Borrow
    {
        public int Id { get; set; }
        public virtual Copy Copy { get; set; }
        public DateTime BorrowDate { get;set; }
        public User User { get; set; }
    }
}
