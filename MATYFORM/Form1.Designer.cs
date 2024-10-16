namespace WindowsFormsApp1
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
            this.button_inicio = new System.Windows.Forms.Button();
            this.button_terminar = new System.Windows.Forms.Button();
            this.button_salir = new System.Windows.Forms.Button();
            this.label_ti = new System.Windows.Forms.Label();
            this.label_tdt = new System.Windows.Forms.Label();
            this.label_ttr = new System.Windows.Forms.Label();
            this.textBox_tiempoi = new System.Windows.Forms.TextBox();
            this.textBox_tiempodt = new System.Windows.Forms.TextBox();
            this.textBox_Tiempotra = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_inicio
            // 
            this.button_inicio.Location = new System.Drawing.Point(44, 32);
            this.button_inicio.Name = "button_inicio";
            this.button_inicio.Size = new System.Drawing.Size(75, 23);
            this.button_inicio.TabIndex = 0;
            this.button_inicio.Text = "inicio";
            this.button_inicio.UseVisualStyleBackColor = true;
            this.button_inicio.Click += new System.EventHandler(this.button_inicio_Click);
            // 
            // button_terminar
            // 
            this.button_terminar.Enabled = false;
            this.button_terminar.Location = new System.Drawing.Point(44, 71);
            this.button_terminar.Name = "button_terminar";
            this.button_terminar.Size = new System.Drawing.Size(75, 23);
            this.button_terminar.TabIndex = 1;
            this.button_terminar.Text = "Terminar";
            this.button_terminar.UseVisualStyleBackColor = true;
            this.button_terminar.Click += new System.EventHandler(this.button_terminar_Click);
            // 
            // button_salir
            // 
            this.button_salir.Location = new System.Drawing.Point(44, 112);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(75, 23);
            this.button_salir.TabIndex = 2;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // label_ti
            // 
            this.label_ti.AutoSize = true;
            this.label_ti.Location = new System.Drawing.Point(138, 37);
            this.label_ti.Name = "label_ti";
            this.label_ti.Size = new System.Drawing.Size(72, 13);
            this.label_ti.TabIndex = 3;
            this.label_ti.Text = "Tiempo Inicial";
            // 
            // label_tdt
            // 
            this.label_tdt.AutoSize = true;
            this.label_tdt.Location = new System.Drawing.Point(138, 81);
            this.label_tdt.Name = "label_tdt";
            this.label_tdt.Size = new System.Drawing.Size(100, 13);
            this.label_tdt.TabIndex = 4;
            this.label_tdt.Text = "Tiempo De Termino";
            // 
            // label_ttr
            // 
            this.label_ttr.AutoSize = true;
            this.label_ttr.Location = new System.Drawing.Point(138, 122);
            this.label_ttr.Name = "label_ttr";
            this.label_ttr.Size = new System.Drawing.Size(104, 13);
            this.label_ttr.TabIndex = 5;
            this.label_ttr.Text = "Tiempo Transcurrido";
            // 
            // textBox_tiempoi
            // 
            this.textBox_tiempoi.Location = new System.Drawing.Point(249, 32);
            this.textBox_tiempoi.Name = "textBox_tiempoi";
            this.textBox_tiempoi.Size = new System.Drawing.Size(117, 20);
            this.textBox_tiempoi.TabIndex = 6;
            // 
            // textBox_tiempodt
            // 
            this.textBox_tiempodt.Location = new System.Drawing.Point(249, 78);
            this.textBox_tiempodt.Name = "textBox_tiempodt";
            this.textBox_tiempodt.Size = new System.Drawing.Size(117, 20);
            this.textBox_tiempodt.TabIndex = 7;
            // 
            // textBox_Tiempotra
            // 
            this.textBox_Tiempotra.Location = new System.Drawing.Point(249, 119);
            this.textBox_Tiempotra.Name = "textBox_Tiempotra";
            this.textBox_Tiempotra.Size = new System.Drawing.Size(117, 20);
            this.textBox_Tiempotra.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 182);
            this.Controls.Add(this.textBox_Tiempotra);
            this.Controls.Add(this.textBox_tiempodt);
            this.Controls.Add(this.textBox_tiempoi);
            this.Controls.Add(this.label_ttr);
            this.Controls.Add(this.label_tdt);
            this.Controls.Add(this.label_ti);
            this.Controls.Add(this.button_salir);
            this.Controls.Add(this.button_terminar);
            this.Controls.Add(this.button_inicio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_inicio;
        private System.Windows.Forms.Button button_terminar;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.Label label_ti;
        private System.Windows.Forms.Label label_tdt;
        private System.Windows.Forms.Label label_ttr;
        private System.Windows.Forms.TextBox textBox_tiempoi;
        private System.Windows.Forms.TextBox textBox_tiempodt;
        private System.Windows.Forms.TextBox textBox_Tiempotra;
    }
}

