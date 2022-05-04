using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.common
{
    public class Libraryan : Principal
    {
        public Libraryan()
        {
            Staf = new LibraryanDefinition();
        }
        public override bool ConfirmPassword(string passwd, string confirmPasswd)
        {
            return passwd.Equals(confirmPasswd);
        }
    }
}
