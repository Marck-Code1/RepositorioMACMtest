namespace _23100217_Restaurante
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSopa = new System.Windows.Forms.RadioButton();
            this.rbBebida = new System.Windows.Forms.RadioButton();
            this.rbPostre = new System.Windows.Forms.RadioButton();
            this.rbEnsalada = new System.Windows.Forms.RadioButton();
            this.rbPlatilloFuerte = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxAzucar = new System.Windows.Forms.CheckBox();
            this.cbxSal = new System.Windows.Forms.CheckBox();
            this.cbxCarne = new System.Windows.Forms.CheckBox();
            this.cbxPollo = new System.Windows.Forms.CheckBox();
            this.gbxCubiertos = new System.Windows.Forms.GroupBox();
            this.cbxVaso = new System.Windows.Forms.CheckBox();
            this.cbxCuchillo = new System.Windows.Forms.CheckBox();
            this.rbPopotePlastico = new System.Windows.Forms.RadioButton();
            this.rbPopoteCarton = new System.Windows.Forms.RadioButton();
            this.cbxTenedor = new System.Windows.Forms.CheckBox();
            this.cbxCuchara = new System.Windows.Forms.CheckBox();
            this.tbnMostrar = new System.Windows.Forms.Button();
            this.tbnGuardarPedido = new System.Windows.Forms.Button();
            this.bntSalir = new System.Windows.Forms.Button();
            this.dgPedidos = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subiertosolicitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxCubiertos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSopa);
            this.groupBox1.Controls.Add(this.rbBebida);
            this.groupBox1.Controls.Add(this.rbPostre);
            this.groupBox1.Controls.Add(this.rbEnsalada);
            this.groupBox1.Controls.Add(this.rbPlatilloFuerte);
            this.groupBox1.Location = new System.Drawing.Point(26, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu de alimentos";
            // 
            // rbSopa
            // 
            this.rbSopa.AutoSize = true;
            this.rbSopa.Location = new System.Drawing.Point(7, 64);
            this.rbSopa.Name = "rbSopa";
            this.rbSopa.Size = new System.Drawing.Size(50, 17);
            this.rbSopa.TabIndex = 4;
            this.rbSopa.TabStop = true;
            this.rbSopa.Text = "Sopa";
            this.rbSopa.UseVisualStyleBackColor = true;
            this.rbSopa.CheckedChanged += new System.EventHandler(this.rbSopa_CheckedChanged);
            // 
            // rbBebida
            // 
            this.rbBebida.AutoSize = true;
            this.rbBebida.Location = new System.Drawing.Point(7, 111);
            this.rbBebida.Name = "rbBebida";
            this.rbBebida.Size = new System.Drawing.Size(58, 17);
            this.rbBebida.TabIndex = 3;
            this.rbBebida.TabStop = true;
            this.rbBebida.Text = "Bebida";
            this.rbBebida.UseVisualStyleBackColor = true;
            this.rbBebida.CheckedChanged += new System.EventHandler(this.rbBebida_CheckedChanged);
            // 
            // rbPostre
            // 
            this.rbPostre.AutoSize = true;
            this.rbPostre.Location = new System.Drawing.Point(6, 87);
            this.rbPostre.Name = "rbPostre";
            this.rbPostre.Size = new System.Drawing.Size(55, 17);
            this.rbPostre.TabIndex = 2;
            this.rbPostre.TabStop = true;
            this.rbPostre.Text = "Postre";
            this.rbPostre.UseVisualStyleBackColor = true;
            this.rbPostre.CheckedChanged += new System.EventHandler(this.rbPostre_CheckedChanged);
            // 
            // rbEnsalada
            // 
            this.rbEnsalada.AutoSize = true;
            this.rbEnsalada.Location = new System.Drawing.Point(6, 42);
            this.rbEnsalada.Name = "rbEnsalada";
            this.rbEnsalada.Size = new System.Drawing.Size(69, 17);
            this.rbEnsalada.TabIndex = 1;
            this.rbEnsalada.TabStop = true;
            this.rbEnsalada.Text = "Ensalada";
            this.rbEnsalada.UseVisualStyleBackColor = true;
            this.rbEnsalada.CheckedChanged += new System.EventHandler(this.rbEnsalada_CheckedChanged);
            // 
            // rbPlatilloFuerte
            // 
            this.rbPlatilloFuerte.AutoSize = true;
            this.rbPlatilloFuerte.Location = new System.Drawing.Point(6, 20);
            this.rbPlatilloFuerte.Name = "rbPlatilloFuerte";
            this.rbPlatilloFuerte.Size = new System.Drawing.Size(88, 17);
            this.rbPlatilloFuerte.TabIndex = 0;
            this.rbPlatilloFuerte.TabStop = true;
            this.rbPlatilloFuerte.Text = "Platillo Fuerte";
            this.rbPlatilloFuerte.UseVisualStyleBackColor = true;
            this.rbPlatilloFuerte.CheckedChanged += new System.EventHandler(this.rbPlatilloFuerte_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxAzucar);
            this.groupBox2.Controls.Add(this.cbxSal);
            this.groupBox2.Controls.Add(this.cbxCarne);
            this.groupBox2.Controls.Add(this.cbxPollo);
            this.groupBox2.Location = new System.Drawing.Point(26, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingredientes";
            // 
            // cbxAzucar
            // 
            this.cbxAzucar.AutoSize = true;
            this.cbxAzucar.Location = new System.Drawing.Point(6, 89);
            this.cbxAzucar.Name = "cbxAzucar";
            this.cbxAzucar.Size = new System.Drawing.Size(59, 17);
            this.cbxAzucar.TabIndex = 3;
            this.cbxAzucar.Text = "Azúcar";
            this.cbxAzucar.UseVisualStyleBackColor = true;
            // 
            // cbxSal
            // 
            this.cbxSal.AutoSize = true;
            this.cbxSal.Location = new System.Drawing.Point(6, 66);
            this.cbxSal.Name = "cbxSal";
            this.cbxSal.Size = new System.Drawing.Size(41, 17);
            this.cbxSal.TabIndex = 2;
            this.cbxSal.Text = "Sal";
            this.cbxSal.UseVisualStyleBackColor = true;
            // 
            // cbxCarne
            // 
            this.cbxCarne.AutoSize = true;
            this.cbxCarne.Location = new System.Drawing.Point(6, 43);
            this.cbxCarne.Name = "cbxCarne";
            this.cbxCarne.Size = new System.Drawing.Size(54, 17);
            this.cbxCarne.TabIndex = 1;
            this.cbxCarne.Text = "Carne";
            this.cbxCarne.UseVisualStyleBackColor = true;
            // 
            // cbxPollo
            // 
            this.cbxPollo.AutoSize = true;
            this.cbxPollo.Location = new System.Drawing.Point(6, 20);
            this.cbxPollo.Name = "cbxPollo";
            this.cbxPollo.Size = new System.Drawing.Size(49, 17);
            this.cbxPollo.TabIndex = 0;
            this.cbxPollo.Text = "Pollo";
            this.cbxPollo.UseVisualStyleBackColor = true;
            // 
            // gbxCubiertos
            // 
            this.gbxCubiertos.Controls.Add(this.cbxVaso);
            this.gbxCubiertos.Controls.Add(this.cbxCuchillo);
            this.gbxCubiertos.Controls.Add(this.rbPopotePlastico);
            this.gbxCubiertos.Controls.Add(this.rbPopoteCarton);
            this.gbxCubiertos.Controls.Add(this.cbxTenedor);
            this.gbxCubiertos.Controls.Add(this.cbxCuchara);
            this.gbxCubiertos.Location = new System.Drawing.Point(241, 21);
            this.gbxCubiertos.Name = "gbxCubiertos";
            this.gbxCubiertos.Size = new System.Drawing.Size(185, 155);
            this.gbxCubiertos.TabIndex = 2;
            this.gbxCubiertos.TabStop = false;
            this.gbxCubiertos.Text = "Cubiertos";
            // 
            // cbxVaso
            // 
            this.cbxVaso.AutoSize = true;
            this.cbxVaso.Location = new System.Drawing.Point(6, 88);
            this.cbxVaso.Name = "cbxVaso";
            this.cbxVaso.Size = new System.Drawing.Size(50, 17);
            this.cbxVaso.TabIndex = 7;
            this.cbxVaso.Text = "Vaso";
            this.cbxVaso.UseVisualStyleBackColor = true;
            // 
            // cbxCuchillo
            // 
            this.cbxCuchillo.AutoSize = true;
            this.cbxCuchillo.Location = new System.Drawing.Point(6, 65);
            this.cbxCuchillo.Name = "cbxCuchillo";
            this.cbxCuchillo.Size = new System.Drawing.Size(63, 17);
            this.cbxCuchillo.TabIndex = 6;
            this.cbxCuchillo.Text = "Cuchillo";
            this.cbxCuchillo.UseVisualStyleBackColor = true;
            // 
            // rbPopotePlastico
            // 
            this.rbPopotePlastico.AutoSize = true;
            this.rbPopotePlastico.Location = new System.Drawing.Point(6, 134);
            this.rbPopotePlastico.Name = "rbPopotePlastico";
            this.rbPopotePlastico.Size = new System.Drawing.Size(114, 17);
            this.rbPopotePlastico.TabIndex = 5;
            this.rbPopotePlastico.TabStop = true;
            this.rbPopotePlastico.Text = "Popote de Plastico";
            this.rbPopotePlastico.UseVisualStyleBackColor = true;
            // 
            // rbPopoteCarton
            // 
            this.rbPopoteCarton.AutoSize = true;
            this.rbPopoteCarton.Location = new System.Drawing.Point(6, 111);
            this.rbPopoteCarton.Name = "rbPopoteCarton";
            this.rbPopoteCarton.Size = new System.Drawing.Size(108, 17);
            this.rbPopoteCarton.TabIndex = 4;
            this.rbPopoteCarton.TabStop = true;
            this.rbPopoteCarton.Text = "Popote de Carton";
            this.rbPopoteCarton.UseVisualStyleBackColor = true;
            // 
            // cbxTenedor
            // 
            this.cbxTenedor.AutoSize = true;
            this.cbxTenedor.Location = new System.Drawing.Point(6, 42);
            this.cbxTenedor.Name = "cbxTenedor";
            this.cbxTenedor.Size = new System.Drawing.Size(66, 17);
            this.cbxTenedor.TabIndex = 1;
            this.cbxTenedor.Text = "Tenedor";
            this.cbxTenedor.UseVisualStyleBackColor = true;
            // 
            // cbxCuchara
            // 
            this.cbxCuchara.AutoSize = true;
            this.cbxCuchara.Location = new System.Drawing.Point(6, 19);
            this.cbxCuchara.Name = "cbxCuchara";
            this.cbxCuchara.Size = new System.Drawing.Size(66, 17);
            this.cbxCuchara.TabIndex = 0;
            this.cbxCuchara.Text = "Cuchara";
            this.cbxCuchara.UseVisualStyleBackColor = true;
            // 
            // tbnMostrar
            // 
            this.tbnMostrar.Location = new System.Drawing.Point(189, 348);
            this.tbnMostrar.Name = "tbnMostrar";
            this.tbnMostrar.Size = new System.Drawing.Size(85, 54);
            this.tbnMostrar.TabIndex = 3;
            this.tbnMostrar.Text = "Mostrar Pedido";
            this.tbnMostrar.UseVisualStyleBackColor = true;
            this.tbnMostrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbnGuardarPedido
            // 
            this.tbnGuardarPedido.Location = new System.Drawing.Point(62, 348);
            this.tbnGuardarPedido.Name = "tbnGuardarPedido";
            this.tbnGuardarPedido.Size = new System.Drawing.Size(85, 54);
            this.tbnGuardarPedido.TabIndex = 4;
            this.tbnGuardarPedido.Text = "Guardar Pedido";
            this.tbnGuardarPedido.UseVisualStyleBackColor = true;
            this.tbnGuardarPedido.Click += new System.EventHandler(this.tbnGuardarPedido_Click);
            // 
            // bntSalir
            // 
            this.bntSalir.Location = new System.Drawing.Point(305, 348);
            this.bntSalir.Name = "bntSalir";
            this.bntSalir.Size = new System.Drawing.Size(85, 54);
            this.bntSalir.TabIndex = 5;
            this.bntSalir.Text = "Salir";
            this.bntSalir.UseVisualStyleBackColor = true;
            this.bntSalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgPedidos
            // 
            this.dgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.precio,
            this.menu,
            this.ingredientes,
            this.subiertosolicitado});
            this.dgPedidos.Location = new System.Drawing.Point(12, 407);
            this.dgPedidos.Name = "dgPedidos";
            this.dgPedidos.Size = new System.Drawing.Size(425, 184);
            this.dgPedidos.TabIndex = 6;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre del Platillo";
            this.nombre.Name = "nombre";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.Width = 50;
            // 
            // menu
            // 
            this.menu.HeaderText = "Orden Pedida";
            this.menu.Name = "menu";
            // 
            // ingredientes
            // 
            this.ingredientes.HeaderText = "Ingredientes";
            this.ingredientes.Name = "ingredientes";
            this.ingredientes.Width = 150;
            // 
            // subiertosolicitado
            // 
            this.subiertosolicitado.HeaderText = "Cubiertos Solicitado";
            this.subiertosolicitado.Name = "subiertosolicitado";
            this.subiertosolicitado.Width = 150;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPrecio);
            this.groupBox4.Controls.Add(this.txtNombre);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(236, 195);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(190, 127);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos del Platillo";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(12, 86);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(151, 20);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(11, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 603);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgPedidos);
            this.Controls.Add(this.bntSalir);
            this.Controls.Add(this.tbnGuardarPedido);
            this.Controls.Add(this.tbnMostrar);
            this.Controls.Add(this.gbxCubiertos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurante";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxCubiertos.ResumeLayout(false);
            this.gbxCubiertos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPedidos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbxCubiertos;
        private System.Windows.Forms.Button tbnMostrar;
        private System.Windows.Forms.Button tbnGuardarPedido;
        private System.Windows.Forms.Button bntSalir;
        private System.Windows.Forms.DataGridView dgPedidos;
        private System.Windows.Forms.CheckBox cbxCarne;
        private System.Windows.Forms.CheckBox cbxPollo;
        private System.Windows.Forms.CheckBox cbxCuchillo;
        private System.Windows.Forms.RadioButton rbPopotePlastico;
        private System.Windows.Forms.RadioButton rbPopoteCarton;
        private System.Windows.Forms.CheckBox cbxTenedor;
        private System.Windows.Forms.CheckBox cbxCuchara;
        private System.Windows.Forms.CheckBox cbxVaso;
        private System.Windows.Forms.RadioButton rbBebida;
        private System.Windows.Forms.RadioButton rbPostre;
        private System.Windows.Forms.RadioButton rbEnsalada;
        private System.Windows.Forms.RadioButton rbPlatilloFuerte;
        private System.Windows.Forms.RadioButton rbSopa;
        private System.Windows.Forms.CheckBox cbxSal;
        private System.Windows.Forms.CheckBox cbxAzucar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn subiertosolicitado;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

