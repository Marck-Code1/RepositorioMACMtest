using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23100217_Restaurante
{
    internal class clsEnsalada : clsAlimento
    {

        public bool Pollo { get; set; }
        public bool Sal {  get; set; }
        
        public clsEnsalada(string Nombre, double Precio,bool Pollo,bool Sal) : base(Nombre, Precio)
        {
            Pollo = this.Pollo;
            Sal = this.Sal;
        }

        public string Pedidos()
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

            return Ingredientes;
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
            return base.ToString() + "\nSolicitud: Ensalada\n" + "\nIngredinetes: " + Ingredientes;
        }

    }
}
