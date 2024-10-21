using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23100217_Restaurante
{
    internal class clsPlatilloFuerte : clsAlimento
    {
        public bool Pollo { get; set; }
        public bool Sal {  get; set; }
        public bool Carne { get; set; }


        public clsPlatilloFuerte(string Nombre, double Precio, bool pollo, bool sal, bool carne) : base(Nombre, Precio)
        {
            Pollo = pollo;
            Sal = sal;
            Carne = carne;
            
        }
        public string Ingredientes()
        {
            string Ingredientes = "";

            if (Pollo == true)
            {
                Ingredientes = Ingredientes + "Pollo, ";

            }
            if (Sal == true)
            {
                Ingredientes = Ingredientes + "Sal, ";
            }
            if (Carne == true)
            {
                Ingredientes = Ingredientes + "Carne, ";
            }
            return Ingredientes;
        }

        public override string ToString()
        {


            return (base.ToString() + "\nSolicitud: Platillo Fuerte\nIngredinetes: " + Ingredientes()+"\nCubiertos solicitado: ");
        }
    }
}
