using Lybrary.common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.common
{
    public abstract class Principal
    {
        public Principal()
        {

        }
        public IStaf? Staf { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }

        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? UserName { get; set; }
        public Roole IsAdmin
        {
            get => Staf.IsAdmin();
           
        }
        public abstract bool ConfirmPassword(string passwd, string confirmPasswd);

    }
}
