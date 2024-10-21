using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23100217_Restaurante
{
    internal class clsSopa:clsAlimento
    {
        public bool Pollo {  get; set; }
        public bool Sal {  get; set; }


        public clsSopa(string Nombre, double Precio,bool Pollo, bool Sal) : base (Nombre, Precio) 
        {
            Pollo = this.Pollo;
            Sal = this.Sal;
        }

        public override string ToString()
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
            return base.ToString()+"\nSolicitud: Sopa"  + "\nIngredinetes: " + Ingredientes;
        }

    }
}
