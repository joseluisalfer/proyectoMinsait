using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecoEventos
{
    internal class Categoria
    {
        // Atributos
        private static int contId = 1;
        private int id;
        private string nombre;

        // Constructor
        public Categoria(int id, string nombre)
        {
            this.id = contId++;
            this.nombre = nombre;
        }

        // Propiedades
        public int Id { get { return id; } set { id = value; } }
        public string Nombre { get { return nombre;} set {nombre = value;} }

    }
}
