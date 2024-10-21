using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23100217_Restaurante
{
    internal class clsAlimento
    {
        public string Nombre {  get; set; }
        public double Precio { get; set; }


        public clsAlimento(string Nombre, double Precio)
        {
            Nombre = this.Nombre;
            Precio = this.Precio;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + "\nPrecio: $" + Precio;
            
        }
    }
}
