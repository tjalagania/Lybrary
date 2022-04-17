using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.common
{
    public class Author : Principal
    {
        public override bool ConfirmPassword(string passwd, string confirmPasswd)
        {
            throw new NotImplementedException();
        }
    }
}
