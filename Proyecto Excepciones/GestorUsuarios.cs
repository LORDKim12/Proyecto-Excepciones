using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Excepciones
{
    public class GestorUsuarios
    {
        // Lista en memoria
        private List<Usuarios> listaUsuarios = new List<Usuarios>();

        // Método que demuestra PROPAGACIÓN: Llama a otros métodos que pueden fallar
        public void RegistrarUsuario(string nombre, string edadTexto, string correo)
        {
            // 1. Validar Nombre (Lanza ArgumentNullException)
            ValidarNombre(nombre);

            // 2. Validar Edad (Propaga FormatException o OverflowException)
            int edad = ConvertirEdad(edadTexto);

            // 3. Validar Reglas de Negocio (Lanza RegistroUsuarioException)
            ValidarReglasNegocio(nombre, edad, correo);

            // Si todo pasa, guardamos
            listaUsuarios.Add(new Usuarios(nombre, edad, correo));
        }

        private void ValidarNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentNullException("nombre", "El nombre no puede estar vacío (Error Técnico: ArgumentNull).");
        }

        private int ConvertirEdad(string edadTexto)
        {
            // Este método NO tiene try-catch. Si int.Parse falla, 
            // la excepción (FormatException) "sube" automáticamente (Propagación).
            return int.Parse(edadTexto);
        }

        private void ValidarReglasNegocio(string nombre, int edad, string correo)
        {
            // Regla: Edad
            if (edad < 18 || edad > 99)
                throw new RegistroUsuarioException("La edad debe estar entre 18 y 99 años.");

            // Regla: Correo
            if (!correo.Contains("@") || !correo.Contains("."))
                throw new RegistroUsuarioException("El formato del correo es inválido.");

            // Regla: Duplicados
            // Usamos Linq para buscar si ya existe
            if (listaUsuarios.Any(u => u.nombre == nombre || u.correo == correo))
                throw new RegistroUsuarioException("El usuario o el correo ya existen en el sistema.");
        }

        public List<Usuarios> ObtenerUsuarios()
        {
            return listaUsuarios;
        }

        public Usuarios BuscarPorIndice(string indiceTexto)
        {
            // Simulación para provocar IndexOutOfRangeException
            // Si el usuario escribe un número en la búsqueda, buscamos por posición
            if (int.TryParse(indiceTexto, out int indice))
            {
                // Esto lanzará IndexOutOfRangeException si el indice no existe
                return listaUsuarios[indice];
            }
            return null;
        }
    }
}
