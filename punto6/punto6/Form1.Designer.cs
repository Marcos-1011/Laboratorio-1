namespace punto6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            CapacidadPerso = new TextBox();
            Asistencia = new TextBox();
            CalculoPorcentaje = new Button();
            AumentoPersonas = new Button();
            DisminuirPersonas = new Button();
            bCerrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(148, 107);
            label1.Name = "label1";
            label1.Size = new Size(321, 17);
            label1.TabIndex = 0;
            label1.Text = "Ingrese la capacidad de personas de la sala de cine";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(260, 135);
            label2.Name = "label2";
            label2.Size = new Size(209, 17);
            label2.TabIndex = 1;
            label2.Text = "Ingrese las personas q asistieron";
            // 
            // CapacidadPerso
            // 
            CapacidadPerso.Location = new Point(489, 101);
            CapacidadPerso.Name = "CapacidadPerso";
            CapacidadPerso.Size = new Size(100, 23);
            CapacidadPerso.TabIndex = 2;
            // 
            // Asistencia
            // 
            Asistencia.Location = new Point(489, 134);
            Asistencia.Name = "Asistencia";
            Asistencia.Size = new Size(100, 23);
            Asistencia.TabIndex = 3;
            // 
            // CalculoPorcentaje
            // 
            CalculoPorcentaje.BackColor = Color.DarkRed;
            CalculoPorcentaje.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            CalculoPorcentaje.ForeColor = SystemColors.ControlLightLight;
            CalculoPorcentaje.Location = new Point(316, 190);
            CalculoPorcentaje.Name = "CalculoPorcentaje";
            CalculoPorcentaje.Size = new Size(153, 36);
            CalculoPorcentaje.TabIndex = 6;
            CalculoPorcentaje.Text = "Calcular porcentaje";
            CalculoPorcentaje.UseVisualStyleBackColor = false;
            CalculoPorcentaje.Click += button1_Click;
            // 
            // AumentoPersonas
            // 
            AumentoPersonas.BackColor = Color.DarkRed;
            AumentoPersonas.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            AumentoPersonas.ForeColor = SystemColors.ControlLightLight;
            AumentoPersonas.Location = new Point(316, 232);
            AumentoPersonas.Name = "AumentoPersonas";
            AumentoPersonas.Size = new Size(153, 36);
            AumentoPersonas.TabIndex = 7;
            AumentoPersonas.Text = "Aumentar personas";
            AumentoPersonas.UseVisualStyleBackColor = false;
            AumentoPersonas.Click += button2_Click;
            // 
            // DisminuirPersonas
            // 
            DisminuirPersonas.BackColor = Color.DarkRed;
            DisminuirPersonas.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            DisminuirPersonas.ForeColor = SystemColors.ControlLightLight;
            DisminuirPersonas.Location = new Point(316, 274);
            DisminuirPersonas.Name = "DisminuirPersonas";
            DisminuirPersonas.Size = new Size(153, 35);
            DisminuirPersonas.TabIndex = 8;
            DisminuirPersonas.Text = "Disminuir personas";
            DisminuirPersonas.UseVisualStyleBackColor = false;
            DisminuirPersonas.Click += DisminuirPersonas_Click;
            // 
            // bCerrar
            // 
            bCerrar.Location = new Point(578, 280);
            bCerrar.Name = "bCerrar";
            bCerrar.Size = new Size(75, 23);
            bCerrar.TabIndex = 9;
            bCerrar.Text = "Cerrar";
            bCerrar.UseVisualStyleBackColor = true;
            bCerrar.Click += bCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(bCerrar);
            Controls.Add(DisminuirPersonas);
            Controls.Add(AumentoPersonas);
            Controls.Add(CalculoPorcentaje);
            Controls.Add(Asistencia);
            Controls.Add(CapacidadPerso);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox CapacidadPerso;
        private TextBox Asistencia;
        private Button CalculoPorcentaje;
        private Button AumentoPersonas;
        private Button DisminuirPersonas;
        private Button bCerrar;
    }
}