using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecoEventos
{
    internal class Organizador
    {
        // Atributos
        private static int contId = 1;
        private int id;
        private string nombre;
        private string email;
        private string telefono;

        // Constructor
        public Organizador(int id, string nombre, string email, string? telefono = null)
        {
            this.id = contId++;
            this.nombre = nombre;
            this.email = email;
            this.telefono = telefono;
        }

        // Propiedades
        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre;} set {nombre = value;} }
        public string Email { get { return email;} set { email = value;} }
        public string Telefono { get { return telefono;} set { telefono = value;} }

        // Métodos

        // Método para crear un evento.
        public Evento CrearEvento(string nombre, DateTime fecha, TimeSpan duracion, Ubicacion ubicacion, Categoria categoria, bool cancelado = false)
        {
            Evento nuevoEvento = new Evento(0, nombre, fecha, duracion, ubicacion, categoria, this, cancelado);
            return nuevoEvento;
        }

        // Método para cancelar un evento.
        public void CancelarEvento(Evento evento)
        {
            if (evento != null)
            {
                evento.Cancelado = true;
            }
        }
        // Método para eliminar un evento basandose en la id del evento.
        public void EliminarEventoPorId(List<Evento> listaEventos, int id)
        {
            Evento eventoAEliminar = null;

            foreach (Evento evento in listaEventos)
            {
                if (evento.Id == id)
                {
                    eventoAEliminar = evento;
                    break;
                }
            }

            if (eventoAEliminar != null)
            {
                listaEventos.Remove(eventoAEliminar);
            }
        }

        // Método para listar eventos y sus usuarios inscritos.
        public void ListarEventosConInscritos(List<Evento> listaEventos)
        {
            foreach (Evento evento in listaEventos)
            {
                Console.WriteLine($"Evento: {evento.Nombre}, Fecha: {evento.Fecha}, Organizador: {this.Nombre}");
                if (evento.Inscripciones.Count > 0)
                {
                    Console.WriteLine("Usuarios inscritos:");
                    foreach (Inscripcion inscripcion in evento.Inscripciones)
                    {
                        Console.WriteLine($"- {inscripcion.Usuario.Nombre} (ID: {inscripcion.Usuario.Id})");
                    }
                }
                else
                {
                    Console.WriteLine("No hay usuarios inscritos.");
                }
            }
        }
}
