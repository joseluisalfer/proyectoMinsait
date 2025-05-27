using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecoEventos
{
    internal class Evento
    {
        // Atributos
        private static int contId = 1;
        private int id;
        private string nombre;
        private DateTime fecha;
        private TimeSpan duracion;
        private Ubicacion ubicacion;
        private Categoria categoria;
        private Organizador organizador;
        private bool cancelado;
        private List<Inscripcion> inscripciones;

        // Constructor
        public Evento(int id, string nombre, DateTime fecha, TimeSpan duracion, Ubicacion ubicacion, Categoria categoria, Organizador organizador, bool cancelado)
        {
            this.id = contId++;
            this.nombre = nombre;
            this.fecha = fecha;
            this.duracion = duracion;
            this.ubicacion = ubicacion;
            this.categoria = categoria;
            this.organizador = organizador;
            this.cancelado = cancelado;
            this.inscripciones = new List<Inscripcion>();
        }

        // Propiedades
        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public DateTime Fecha { get { return fecha; } set { fecha = value; } }
        public TimeSpan Duracion { get { return duracion; } set { duracion = value; } }
        public Ubicacion Ubicacion { get { return ubicacion; } set { ubicacion = value; } }
        public Categoria Categoria { get { return categoria; } set { categoria = value; } }
        public Organizador Organizador { get { return organizador; } set { organizador = value; } }
        public bool Cancelado { get { return cancelado; } set {cancelado = value; } }
        public List<Inscripcion> Inscripciones { get { return inscripciones; } }


        // Métodos

        // Método para inscribir al usuario
        public void InscribirUsuario(Usuario usuario)
        {
            Inscripcion inscripcion = new Inscripcion(0, usuario, this, DateTime.Now);
            Inscripciones.Add(inscripcion);
            usuario.Inscripciones.Add(inscripcion);
        }

        // Método para cancelar el evento

        public static void CancelarEvento(List<Evento> listaEventos)
        {
            Console.Write("Introduce el ID del evento a cancelar: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                foreach (Evento evento in listaEventos)
                {
                    if (evento.Id == id)
                    {
                        evento.Cancelado = true;
                        Console.WriteLine($"Evento: {evento.nombre} cancelado correctamente");
                        return;
                    }
                }

                Console.WriteLine("No se encontró ningún evento con ese ID.");
            }
            else
            {
                Console.WriteLine("ID no válido.");
            }
        }
    }
}
