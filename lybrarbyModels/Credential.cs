using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lybrarbyModels
{
    public class Credential
    {
        public virtual User User { get; set; }
        public string? Username { get; set; }

        public string? Password { get; set; }
        public string? Phone { get; set; }

        public string? Email { get; set; }
        public bool IsAdmin { get; set; }
    }
}
