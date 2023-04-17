namespace Ejercicio9
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
            this.bSumar = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tHoras1 = new System.Windows.Forms.TextBox();
            this.tMinutos1 = new System.Windows.Forms.TextBox();
            this.tSegundos1 = new System.Windows.Forms.TextBox();
            this.tHoras2 = new System.Windows.Forms.TextBox();
            this.tMinutos2 = new System.Windows.Forms.TextBox();
            this.tSegundos2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bSumar
            // 
            this.bSumar.Location = new System.Drawing.Point(629, 404);
            this.bSumar.Name = "bSumar";
            this.bSumar.Size = new System.Drawing.Size(75, 23);
            this.bSumar.TabIndex = 0;
            this.bSumar.Text = "Sumar";
            this.bSumar.UseVisualStyleBackColor = true;
            this.bSumar.Click += new System.EventHandler(this.bSumar_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(713, 404);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 1;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tiempo1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tiempo2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Horas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Minutos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Segundos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Horas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Minutos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Segundos:";
            // 
            // tHoras1
            // 
            this.tHoras1.Location = new System.Drawing.Point(169, 135);
            this.tHoras1.Name = "tHoras1";
            this.tHoras1.Size = new System.Drawing.Size(100, 20);
            this.tHoras1.TabIndex = 10;
            // 
            // tMinutos1
            // 
            this.tMinutos1.Location = new System.Drawing.Point(169, 160);
            this.tMinutos1.Name = "tMinutos1";
            this.tMinutos1.Size = new System.Drawing.Size(100, 20);
            this.tMinutos1.TabIndex = 11;
            // 
            // tSegundos1
            // 
            this.tSegundos1.Location = new System.Drawing.Point(169, 186);
            this.tSegundos1.Name = "tSegundos1";
            this.tSegundos1.Size = new System.Drawing.Size(100, 20);
            this.tSegundos1.TabIndex = 12;
            // 
            // tHoras2
            // 
            this.tHoras2.Location = new System.Drawing.Point(529, 135);
            this.tHoras2.Name = "tHoras2";
            this.tHoras2.Size = new System.Drawing.Size(100, 20);
            this.tHoras2.TabIndex = 13;
            // 
            // tMinutos2
            // 
            this.tMinutos2.Location = new System.Drawing.Point(529, 163);
            this.tMinutos2.Name = "tMinutos2";
            this.tMinutos2.Size = new System.Drawing.Size(100, 20);
            this.tMinutos2.TabIndex = 14;
            // 
            // tSegundos2
            // 
            this.tSegundos2.Location = new System.Drawing.Point(529, 189);
            this.tSegundos2.Name = "tSegundos2";
            this.tSegundos2.Size = new System.Drawing.Size(100, 20);
            this.tSegundos2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tSegundos2);
            this.Controls.Add(this.tMinutos2);
            this.Controls.Add(this.tHoras2);
            this.Controls.Add(this.tSegundos1);
            this.Controls.Add(this.tMinutos1);
            this.Controls.Add(this.tHoras1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bSumar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSumar;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tHoras1;
        private System.Windows.Forms.TextBox tMinutos1;
        private System.Windows.Forms.TextBox tSegundos1;
        private System.Windows.Forms.TextBox tHoras2;
        private System.Windows.Forms.TextBox tMinutos2;
        private System.Windows.Forms.TextBox tSegundos2;
    }
}

