namespace Ejercicio10
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bCerrar = new System.Windows.Forms.Button();
            this.bSalario = new System.Windows.Forms.Button();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tAño = new System.Windows.Forms.TextBox();
            this.tTarifa = new System.Windows.Forms.TextBox();
            this.tHoras = new System.Windows.Forms.TextBox();
            this.tDias = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del empleado:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Año de ingreso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarifa horaria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Horas por dia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad de dias:";
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(703, 415);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 5;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bSalario
            // 
            this.bSalario.Location = new System.Drawing.Point(613, 415);
            this.bSalario.Name = "bSalario";
            this.bSalario.Size = new System.Drawing.Size(75, 23);
            this.bSalario.TabIndex = 6;
            this.bSalario.Text = "Salario";
            this.bSalario.UseVisualStyleBackColor = true;
            this.bSalario.Click += new System.EventHandler(this.bSalario_Click);
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(240, 59);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(100, 20);
            this.tNombre.TabIndex = 7;
            // 
            // tAño
            // 
            this.tAño.Location = new System.Drawing.Point(200, 85);
            this.tAño.Name = "tAño";
            this.tAño.Size = new System.Drawing.Size(100, 20);
            this.tAño.TabIndex = 8;
            // 
            // tTarifa
            // 
            this.tTarifa.Location = new System.Drawing.Point(199, 111);
            this.tTarifa.Name = "tTarifa";
            this.tTarifa.Size = new System.Drawing.Size(100, 20);
            this.tTarifa.TabIndex = 9;
            // 
            // tHoras
            // 
            this.tHoras.Location = new System.Drawing.Point(200, 137);
            this.tHoras.Name = "tHoras";
            this.tHoras.Size = new System.Drawing.Size(100, 20);
            this.tHoras.TabIndex = 10;
            // 
            // tDias
            // 
            this.tDias.Location = new System.Drawing.Point(213, 163);
            this.tDias.Name = "tDias";
            this.tDias.Size = new System.Drawing.Size(101, 20);
            this.tDias.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "$ por hora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tDias);
            this.Controls.Add(this.tHoras);
            this.Controls.Add(this.tTarifa);
            this.Controls.Add(this.tAño);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.bSalario);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bSalario;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tAño;
        private System.Windows.Forms.TextBox tTarifa;
        private System.Windows.Forms.TextBox tHoras;
        private System.Windows.Forms.TextBox tDias;
        private System.Windows.Forms.Label label6;
    }
}

