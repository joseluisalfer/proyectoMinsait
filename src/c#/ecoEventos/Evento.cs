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
        private int id;
        private string nombre;
        private DateTime fecha;
        private TimeSpan duracion;
        private Ubicacion ubicacion;
        private Categoria categoria;
        private Organizador organizador;
        private bool cancelado;

        // Constructor
        public Evento(int id, string nombre, DateTime fecha, TimeSpan duracion, Ubicacion ubicacion, Categoria categoria, Organizador organizador, bool cancelado)
        {
            this.id = id;
            this.nombre = nombre;
            this.fecha = fecha;
            this.duracion = duracion;
            this.ubicacion = ubicacion;
            this.categoria = categoria;
            this.organizador = organizador;
            this.cancelado = cancelado;
        }

        // Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Duracion { get; set; }
        public Ubicacion Ubicacion { get; set; }
        public Categoria Categoria { get; set; }
        public Organizador Organizador { get; set; }
        public bool Cancelado { get; set; }
    }
}
