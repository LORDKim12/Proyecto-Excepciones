using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Excepciones
{
    public class RegistroUsuarioException : Exception
    {
        public RegistroUsuarioException(string mensaje) : base(mensaje) { }
    }
}
