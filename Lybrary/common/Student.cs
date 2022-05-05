using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.common
{
    public class Student : Principal
    {

        public Student()
        {
            Staf = new StudentDefinition();
        }
        public override bool ConfirmPassword(string passwd, string confirmPasswd)
        {
            return passwd.Equals(confirmPasswd,StringComparison.OrdinalIgnoreCase);
        }
    }
}
