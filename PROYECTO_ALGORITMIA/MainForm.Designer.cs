namespace PROYECTO_ALGORITMIA
{
    partial class MainForm
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
            this.rB_Enc = new System.Windows.Forms.RadioButton();
            this.rB_Venta = new System.Windows.Forms.RadioButton();
            this.rB_Prod = new System.Windows.Forms.RadioButton();
            this.rB_Cliente = new System.Windows.Forms.RadioButton();
            this.btn_Capturar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Mostrar = new System.Windows.Forms.Button();
            this.btn_Orden = new System.Windows.Forms.Button();
            this.btn_AVL = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB_Enc);
            this.groupBox1.Controls.Add(this.rB_Venta);
            this.groupBox1.Controls.Add(this.rB_Prod);
            this.groupBox1.Controls.Add(this.rB_Cliente);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(103, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elegir entidad:";
            // 
            // rB_Enc
            // 
            this.rB_Enc.AutoSize = true;
            this.rB_Enc.Location = new System.Drawing.Point(7, 92);
            this.rB_Enc.Name = "rB_Enc";
            this.rB_Enc.Size = new System.Drawing.Size(70, 17);
            this.rB_Enc.TabIndex = 3;
            this.rB_Enc.TabStop = true;
            this.rB_Enc.Text = "Encuesta";
            this.rB_Enc.UseVisualStyleBackColor = true;
            // 
            // rB_Venta
            // 
            this.rB_Venta.AutoSize = true;
            this.rB_Venta.Location = new System.Drawing.Point(7, 68);
            this.rB_Venta.Name = "rB_Venta";
            this.rB_Venta.Size = new System.Drawing.Size(53, 17);
            this.rB_Venta.TabIndex = 2;
            this.rB_Venta.TabStop = true;
            this.rB_Venta.Text = "Venta";
            this.rB_Venta.UseVisualStyleBackColor = true;
            // 
            // rB_Prod
            // 
            this.rB_Prod.AutoSize = true;
            this.rB_Prod.Location = new System.Drawing.Point(7, 44);
            this.rB_Prod.Name = "rB_Prod";
            this.rB_Prod.Size = new System.Drawing.Size(68, 17);
            this.rB_Prod.TabIndex = 1;
            this.rB_Prod.TabStop = true;
            this.rB_Prod.Text = "Producto";
            this.rB_Prod.UseVisualStyleBackColor = true;
            // 
            // rB_Cliente
            // 
            this.rB_Cliente.AutoSize = true;
            this.rB_Cliente.Location = new System.Drawing.Point(7, 20);
            this.rB_Cliente.Name = "rB_Cliente";
            this.rB_Cliente.Size = new System.Drawing.Size(57, 17);
            this.rB_Cliente.TabIndex = 0;
            this.rB_Cliente.TabStop = true;
            this.rB_Cliente.Text = "Cliente";
            this.rB_Cliente.UseVisualStyleBackColor = true;
            // 
            // btn_Capturar
            // 
            this.btn_Capturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Capturar.Location = new System.Drawing.Point(141, 33);
            this.btn_Capturar.Name = "btn_Capturar";
            this.btn_Capturar.Size = new System.Drawing.Size(238, 28);
            this.btn_Capturar.TabIndex = 1;
            this.btn_Capturar.Text = "Capturar";
            this.btn_Capturar.UseVisualStyleBackColor = true;
            this.btn_Capturar.Click += new System.EventHandler(this.btn_Capturar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.Location = new System.Drawing.Point(141, 68);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(238, 28);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Mostrar
            // 
            this.btn_Mostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mostrar.Location = new System.Drawing.Point(141, 103);
            this.btn_Mostrar.Name = "btn_Mostrar";
            this.btn_Mostrar.Size = new System.Drawing.Size(238, 28);
            this.btn_Mostrar.TabIndex = 3;
            this.btn_Mostrar.Text = "Mostrar";
            this.btn_Mostrar.UseVisualStyleBackColor = true;
            this.btn_Mostrar.Click += new System.EventHandler(this.btn_Mostrar_Click);
            // 
            // btn_Orden
            // 
            this.btn_Orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Orden.Location = new System.Drawing.Point(386, 33);
            this.btn_Orden.Name = "btn_Orden";
            this.btn_Orden.Size = new System.Drawing.Size(92, 98);
            this.btn_Orden.TabIndex = 4;
            this.btn_Orden.Text = "Ordenar registros";
            this.btn_Orden.UseVisualStyleBackColor = true;
            this.btn_Orden.Click += new System.EventHandler(this.btn_Orden_Click);
            // 
            // btn_AVL
            // 
            this.btn_AVL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AVL.Location = new System.Drawing.Point(141, 138);
            this.btn_AVL.Name = "btn_AVL";
            this.btn_AVL.Size = new System.Drawing.Size(337, 28);
            this.btn_AVL.TabIndex = 5;
            this.btn_AVL.Text = "Buscar producto por grado de satisfacción";
            this.btn_AVL.UseVisualStyleBackColor = true;
            this.btn_AVL.Click += new System.EventHandler(this.btn_AVL_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 186);
            this.Controls.Add(this.btn_AVL);
            this.Controls.Add(this.btn_Orden);
            this.Controls.Add(this.btn_Mostrar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Capturar);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Sistema Consultas";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rB_Enc;
        private System.Windows.Forms.RadioButton rB_Venta;
        private System.Windows.Forms.RadioButton rB_Prod;
        private System.Windows.Forms.RadioButton rB_Cliente;
        private System.Windows.Forms.Button btn_Capturar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Mostrar;
        private System.Windows.Forms.Button btn_Orden;
        private System.Windows.Forms.Button btn_AVL;
    }
}

