using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecoEventos
{
    internal class Ubicacion
    {
        // Atributos
        private static int contId = 1;
        private int id;
        private string tipo;
        private string direccion;

        // Constructor
        public Ubicacion(int id, string tipo, string direccion)
        {
            this.id = contId++;
            this.tipo = tipo;
            this.direccion = direccion;
        }

        // Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
    }
}
