using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.common
{
    public abstract class Principal<T>
    {
        public string? Name { get; set; }
        public abstract void SetPrincipal(T pricipal);
        public abstract T GetPrincipal();
        public abstract void UpdatePricipal(T pricipal);
        public abstract void DeletePricipal(T principal);
    }
}
