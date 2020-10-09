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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(141, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Capturar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(141, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(141, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Mostrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 158);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

