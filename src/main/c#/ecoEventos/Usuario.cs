using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecoEventos
{
    internal class Usuario
    {
        // Atributos
        private static int contId = 1;
        private int id;
        private string nombre;
        private string email;
        private string contraseña;
        private List<Inscripcion> inscripciones;

        // Constructor
        public Usuario(int id, string nombre, string email, string contraseña)
        {
            this.id = contId++;
            this.nombre = nombre;
            this.email = email;
            this.contraseña = contraseña;
            this.inscripciones = new List<Inscripcion>();
        }

        // Propiedades
        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre;} set {nombre = value;} }
        public string Email { get { return email;} set { email = value;} }
        public string Contraseña { get { return contraseña; } set { contraseña = value; } }
        public List<Inscripcion> Inscripciones { get { return inscripciones; } }

        // Métodos

        // Método para añadir una inscripcion.
        public void AñadirInscripcion(Inscripcion inscripcion)
        {
            if (inscripcion != null)
            {
                inscripciones.Add(inscripcion);
            }
        }

        // Método para eliminar una inscripcion basandose en la id de la inscripción.
        public void EliminarInscripcionPorId(int id)
        {
            Inscripcion inscripcionAEliminar = null;

            foreach (Inscripcion inscripcion in inscripciones)
            {
                if (inscripcion.Id == id)
                {
                    inscripcionAEliminar = inscripcion;
                    break;
                }
            }

            if (inscripcionAEliminar != null)
            {
                inscripciones.Remove(inscripcionAEliminar);
            }
        }
    }
}
