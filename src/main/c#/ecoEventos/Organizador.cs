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
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
    }
}
