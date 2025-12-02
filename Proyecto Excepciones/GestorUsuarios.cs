using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Excepciones
{
    public class GestorUsuarios
    {
        private List<Usuarios> listaUsuarios = new List<Usuarios>();

        public void RegistrarUsuario(string nombre, string edadTexto, string correo)
        {
            ValidarNombre(nombre);

            int edad = ConvertirEdad(edadTexto);

            ValidarReglasNegocio(nombre, edad, correo);

            listaUsuarios.Add(new Usuarios(nombre, edad, correo));
        }

        private void ValidarNombre(string nombre)
        {
            // 1. Validación original (Vacío)
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentNullException("nombre", "El nombre no puede estar vacío (Error Técnico: ArgumentNull).");

            // 2. NUEVA VALIDACIÓN: Solo letras y espacios
            // .All() revisa cada carácter. Si alguno NO es letra y NO es espacio, lanza error.
            if (!nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                // Lanzamos tu excepción personalizada porque es una regla de negocio
                throw new RegistroUsuarioException("El nombre solo puede contener letras, no símbolos ni números.");
            }
        }

        private int ConvertirEdad(string edadTexto)
        {
           
            return int.Parse(edadTexto);
        }

        private void ValidarReglasNegocio(string nombre, int edad, string correo)
        {
            if (edad < 18 || edad > 99)
                throw new RegistroUsuarioException("La edad debe estar entre 18 y 99 años.");

            if (!correo.Contains("@") || !correo.Contains(".com"))
                throw new RegistroUsuarioException("El formato del correo es inválido.");

            if (listaUsuarios.Any(u => u.nombre == nombre || u.correo == correo))
                throw new RegistroUsuarioException("El usuario o el correo ya existen en el sistema.");
        }

        public List<Usuarios> ObtenerUsuarios()
        {
            return listaUsuarios;
        }

        public Usuarios BuscarPorIndice(string indiceTexto)
        {
            // Si el texto es un número válido...
            if (int.TryParse(indiceTexto, out int indice))
            {
                // VERIFICAMOS MANUALMENTE EL RANGO
                // Si el índice es negativo O es mayor/igual a la cantidad de usuarios...
                if (indice < 0 || indice >= listaUsuarios.Count)
                {
                    // ...Lanzamos MANUALMENTE la excepción que pide el profesor
                    throw new IndexOutOfRangeException();
                }

                // Si pasa el if, es seguro acceder
                return listaUsuarios[indice];
            }
            return null;
        }
    }
}
