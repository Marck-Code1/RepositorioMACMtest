using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _23100217_Restaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbPlatilloFuerte.Checked==true)
            {
                clsPlatilloFuerte miPlatilloFuerte = new clsPlatilloFuerte("ADMINISTRADOR", double.Parse("200"), false, false, false);
                miPlatilloFuerte.Nombre = txtNombre.Text;
                miPlatilloFuerte.Precio = double.Parse(txtPrecio.Text);

                if (cbxCarne.Checked == true || cbxCarne.Checked == true || cbxSal.Checked == true || cbxAzucar.Checked == true)
                {
                    if (cbxCarne.Checked == true)
                    {
                        miPlatilloFuerte.Carne = true;
                    }
                    if (cbxPollo.Checked == true)
                    {
                        miPlatilloFuerte.Pollo = true;
                    }
                    if (cbxSal.Checked == true)
                    {
                        miPlatilloFuerte.Sal = true;
                    }
                }
                MessageBox.Show(miPlatilloFuerte.ToString());


            }
            else if(rbEnsalada.Checked==true)
            {

                clsEnsalada miEnsalada = new clsEnsalada("ADMINISTRADOR", double.Parse("200"),false,false);
                miEnsalada.Nombre = txtNombre.Text;
                miEnsalada.Precio = double.Parse(txtPrecio.Text);

                if (cbxSal.Checked == true || cbxPollo.Checked == true)
                {
              
                    if (cbxPollo.Checked == true)
                    {
                        miEnsalada.Pollo = true;
                    }
                    if (cbxSal.Checked == true)
                    {
                        miEnsalada.Sal = true;
                    }
                }
                MessageBox.Show(miEnsalada.ToString());


            }
            else if (rbSopa.Checked==true)
            {

                clsSopa miEnsalada = new clsSopa("ADMINISTRADOR", double.Parse("200"), false, false);
                miEnsalada.Nombre = txtNombre.Text;
                miEnsalada.Precio = double.Parse(txtPrecio.Text);

                if (cbxPollo.Checked == true || cbxSal.Checked == true)
                {

                    if (cbxPollo.Checked == true)
                    {
                        miEnsalada.Pollo = true;
                    }
                    if (cbxSal.Checked == true)
                    {
                        miEnsalada.Sal = true;
                    }
                }
                MessageBox.Show(miEnsalada.ToString());

            }
            else if(rbPostre.Checked==true)
            {
                clsPostre miPostre = new clsPostre("ADMINISTRADOR", double.Parse("200"), false);
                miPostre.Nombre = txtNombre.Text;
                miPostre.Precio = double.Parse(txtPrecio.Text);

                if (cbxAzucar.Checked == true)
                {
                    miPostre.Azucar = true;
                }
                MessageBox.Show(miPostre.ToString());

            }
            else if(rbBebida.Checked==true)
            {
                clsBebida miBebida = new clsBebida("ADMINISTRADOR", double.Parse("200"), false);
                miBebida.Nombre = txtNombre.Text;
                miBebida.Precio = double.Parse(txtPrecio.Text);

                if (cbxAzucar.Checked == true)
                {
                    miBebida.Azucar = true;
                }

                MessageBox.Show(miBebida.ToString());
            }
        }

        public string Ingredinetes()
        {
            string Ingredientes = "";

            if(cbxPollo.Checked == true)
            {
                Ingredientes = Ingredientes + "Pollo, ";
            }
            if(cbxCarne.Checked == true)
            {
                Ingredientes = Ingredientes + "Carne, ";
            }
            if(cbxSal.Checked == true)
            {
                Ingredientes = Ingredientes + "Sal, ";
            }
            if (cbxAzucar.Checked == true)
            {
                Ingredientes = Ingredientes + "Azucar";
            }

            return Ingredientes;
        }

        private void tbnGuardarPedido_Click(object sender, EventArgs e)
        {
            if (rbPlatilloFuerte.Checked == true)
            {
                if (txtNombre.Text != "")
                {
                    if (txtPrecio.Text != "")
                    {

                        dgPedidos.Rows.Add(txtNombre.Text, txtPrecio.Text, "Platillo Fuerte", Ingredinetes(), Cubiertos());
                        MessageBox.Show("Precione Mostrar Pedido para que gurde el pedido en el sistema", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);




                    }
                    else { MessageBox.Show("No deje el precio Vacio", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                    
                }
                else { MessageBox.Show("No deje el nombre Vacio", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }
            else if (rbEnsalada.Checked == true)
            {
                if (txtNombre.Text != "")
                {
                    if (txtPrecio.Text != "")
                    {

                        dgPedidos.Rows.Add(txtNombre.Text, txtPrecio.Text, "Ensalada", Ingredinetes(), Cubiertos());
                        MessageBox.Show("Precione Mostrar Pedido para que gurde el pedido en el sistema", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else { MessageBox.Show("No deje el precio Vacio", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else { MessageBox.Show("No deje el nombre Vacio", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }
            else if (rbSopa.Checked == true)
            {
                if (txtNombre.Text != "")
                {
                    if (txtPrecio.Text != "")
                    {

                        dgPedidos.Rows.Add(txtNombre.Text, txtPrecio.Text, "Sopa", Ingredinetes(), Cubiertos());
                        MessageBox.Show("Precione Mostrar Pedido para que gurde el pedido en el sistema", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else { MessageBox.Show("No deje el precio Vacio", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else { MessageBox.Show("No deje el nombre Vacio", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }
            else if (rbPostre.Checked == true)
            {
                if (txtNombre.Text != "")
                {
                    if (txtPrecio.Text != "")
                    {

                        dgPedidos.Rows.Add(txtNombre.Text, txtPrecio.Text, "Postre", Ingredinetes(), Cubiertos());
                        MessageBox.Show("Precione Mostrar Pedido para que gurde el pedido en el sistema", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    }
                    else { MessageBox.Show("No deje el precio Vacio", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else { MessageBox.Show("No deje el nombre Vacio", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }
            else if (rbBebida.Checked == true)
            {
                if (txtNombre.Text != "")
                {
                    if (txtPrecio.Text != "")
                    {
                        dgPedidos.Rows.Add(txtNombre.Text, txtPrecio.Text, "Bebida", Ingredinetes(), Cubiertos());
                        MessageBox.Show("Precione Mostrar Pedido para que gurde el pedido en el sistema", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    else { MessageBox.Show("No deje el precio Vacio", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else { MessageBox.Show("No deje el nombre Vacio", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }

        }

        public string  Cubiertos()
        {
            string Cubiertos = "";
            if (cbxCuchara.Checked == true)
            {
                Cubiertos = Cubiertos + "Cuchara, ";
            }
            if (cbxTenedor.Checked == true)
            {
                Cubiertos = Cubiertos + "Tenedor, ";

            }
            if (cbxCuchillo.Checked == true)
            {
                Cubiertos = Cubiertos + "Chuchillo, ";

            }
            if (cbxVaso.Checked == true)
            {
                Cubiertos = Cubiertos + "Vaso, ";

            }
            if (rbPopotePlastico.Checked == true)
            {
                Cubiertos = Cubiertos + "Popote de plastico";

            }
            else if(rbPopoteCarton.Checked == true)
            {
                Cubiertos = Cubiertos + "Popote de carton";

            }

            return Cubiertos;
        }

        private void rbPlatilloFuerte_CheckedChanged(object sender, EventArgs e)
        {
            DeseleccionarRadioButtons(gbxCubiertos);

            cbxAzucar.Enabled = false;
            cbxCarne.Enabled = true;
            cbxSal.Enabled = true;
            cbxPollo.Enabled = true;

            cbxCuchara.Enabled = true;
            cbxTenedor.Enabled = true;
            cbxCuchillo.Enabled = true;
            cbxVaso.Enabled = false;
            rbPopoteCarton.Enabled = false;
            rbPopotePlastico.Enabled = false;





        }

        private void rbEnsalada_CheckedChanged(object sender, EventArgs e)
        {
            DeseleccionarRadioButtons(gbxCubiertos);

            cbxAzucar.Enabled = false;
            cbxCarne.Enabled = false;
            cbxSal.Enabled = true;
            cbxPollo.Enabled = true;

            cbxCuchara.Enabled = false;
            cbxTenedor.Enabled = true;
            cbxCuchillo.Enabled = false;
            cbxVaso.Enabled = false;
            rbPopoteCarton.Enabled = false;
            rbPopotePlastico.Enabled = false;

        }

        private void rbSopa_CheckedChanged(object sender, EventArgs e)
        {
            DeseleccionarRadioButtons(gbxCubiertos);

            cbxAzucar.Enabled = false;
            cbxCarne.Enabled = false;
            cbxSal.Enabled = true;
            cbxPollo.Enabled = true;

            cbxCuchara.Enabled = true;
            cbxTenedor.Enabled = false;
            cbxCuchillo.Enabled = false;
            cbxVaso.Enabled = false;
            rbPopoteCarton.Enabled = false;
            rbPopotePlastico.Enabled = false;

            
        }

        private void rbPostre_CheckedChanged(object sender, EventArgs e)
        {
            DeseleccionarRadioButtons(gbxCubiertos);

            cbxAzucar.Enabled = true;
            cbxCarne.Enabled = false;
            cbxSal.Enabled = false;
            cbxPollo.Enabled = false;

            cbxCuchara.Enabled = true;
            cbxTenedor.Enabled = true;
            cbxCuchillo.Enabled = false;
            cbxVaso.Enabled = false;
            rbPopoteCarton.Enabled = false;
            rbPopotePlastico.Enabled = false;

         
        }

        private void DeseleccionarRadioButtons(Control container)
        {
            foreach (Control control in container.Controls)
            {
                if (control is RadioButton)
                {
                    ((RadioButton)control).Checked = false;
                }
            }
        }


        private void rbBebida_CheckedChanged(object sender, EventArgs e)
        {
            DeseleccionarRadioButtons(gbxCubiertos);

            cbxAzucar.Enabled = true;
            cbxCarne.Enabled = false;
            cbxSal.Enabled = false;
            cbxPollo.Enabled = false;

            cbxCuchara.Enabled = false;
            cbxTenedor.Enabled = false;
            cbxCuchillo.Enabled = false;
            cbxVaso.Enabled = true;
            rbPopoteCarton.Enabled = true;
            rbPopotePlastico.Enabled = true;
        }

        
    }
}
