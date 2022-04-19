using Lybrary.common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lybrary.common
{
    public class StudentDefinition : IStaf
    { 
        public Roole IsAdmin() => Roole.Student;
    }
}
