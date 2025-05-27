using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecoEventos
{
    internal class Inscripcion
    {
        // Atributos
        private static int contId = 1;
        private int id;
        private Usuario usuario;
        private Evento evento;
        private DateTime fechaInscripcion;

        // Constructor
        public Inscripcion(int id, Usuario usuario, Evento evento, DateTime fechaInscripcion)
        {
            this.id = contId++;
            this.usuario = usuario;
            this.evento = evento;
            this.fechaInscripcion = fechaInscripcion;
        }

        // Propiedades
        public int Id { get { return id; } set { id = value; } }
        public Usuario Usuario { get { return usuario; } set { usuario = value; } }
        public Evento Evento { get { return evento; } set { evento = value; } }
        public DateTime FechaInscripcion { get { return fechaInscripcion; } set { fechaInscripcion = value; } }


    }
}
