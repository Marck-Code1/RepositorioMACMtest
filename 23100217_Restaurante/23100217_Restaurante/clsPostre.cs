using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23100217_Restaurante
{
    internal class clsPostre : clsAlimento
    {

        public bool Azucar {  get; set; }


        public clsPostre(string Nombre, double Precio, bool Azucar) : base (Nombre, Precio) 
        {
            Azucar = this.Azucar;
        }

        public override string ToString()
        {
            string Ingredientes = "";
            if (Azucar == true)
            {
                Ingredientes = "Azucar";
            }
            return base.ToString()+"\nPedido: Postre \nIngredientes: "+Ingredientes;
        }
    }
}
