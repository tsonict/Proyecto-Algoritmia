namespace PROYECTO_ALGORITMIA
{
    partial class FormAVL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMostrar = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.nud_Grado = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Grado)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMostrar
            // 
            this.textBoxMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMostrar.Location = new System.Drawing.Point(13, 13);
            this.textBoxMostrar.Multiline = true;
            this.textBoxMostrar.Name = "textBoxMostrar";
            this.textBoxMostrar.Size = new System.Drawing.Size(284, 199);
            this.textBoxMostrar.TabIndex = 0;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(318, 141);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(137, 33);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.Location = new System.Drawing.Point(318, 180);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(135, 32);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // nud_Grado
            // 
            this.nud_Grado.Location = new System.Drawing.Point(318, 95);
            this.nud_Grado.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_Grado.Name = "nud_Grado";
            this.nud_Grado.Size = new System.Drawing.Size(137, 20);
            this.nud_Grado.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Grado de satisfacción:";
            // 
            // FormAVL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 226);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_Grado);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxMostrar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormAVL";
            this.Text = "FormAVL";
            this.Load += new System.EventHandler(this.FormAVL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Grado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMostrar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.NumericUpDown nud_Grado;
        private System.Windows.Forms.Label label1;
    }
}