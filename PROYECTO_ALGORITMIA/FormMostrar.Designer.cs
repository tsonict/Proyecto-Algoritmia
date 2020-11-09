namespace PROYECTO_ALGORITMIA
{
    partial class FormMostrar
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
            this.Deslizadora = new System.Windows.Forms.HScrollBar();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textMostrar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Deslizadora
            // 
            this.Deslizadora.LargeChange = 1;
            this.Deslizadora.Location = new System.Drawing.Point(9, 201);
            this.Deslizadora.Name = "Deslizadora";
            this.Deslizadora.Size = new System.Drawing.Size(212, 21);
            this.Deslizadora.TabIndex = 0;
            this.Deslizadora.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Deslizadora_Scroll);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(236, 199);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por ID:";
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(236, 31);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(100, 20);
            this.textBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(236, 57);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // textMostrar
            // 
            this.textMostrar.AcceptsReturn = true;
            this.textMostrar.AcceptsTab = true;
            this.textMostrar.CausesValidation = false;
            this.textMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textMostrar.Location = new System.Drawing.Point(13, 5);
            this.textMostrar.Multiline = true;
            this.textMostrar.Name = "textMostrar";
            this.textMostrar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textMostrar.Size = new System.Drawing.Size(208, 176);
            this.textMostrar.TabIndex = 5;
            // 
            // FormMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 239);
            this.Controls.Add(this.textMostrar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.Deslizadora);
            this.Name = "FormMostrar";
            this.Text = "FormMostrar";
            this.Load += new System.EventHandler(this.FormMostrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar Deslizadora;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textMostrar;
    }
}