using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Excepciones
{
    internal class Usuarios
    {
        public string? nombre;
        public int? edad;
        public string? correo;

        public Usuarios(string? nombre, int? edad, string? correo) { this.nombre = nombre; this.edad = edad; this.correo = correo; }
                
        public interface Ierrores { }
        

        
    }

    
}
