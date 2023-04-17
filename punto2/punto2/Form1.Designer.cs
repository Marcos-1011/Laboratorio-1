namespace punto2
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
            VelocidadConstante = new Label();
            LugarViaje = new TextBox();
            DistanciaKM = new TextBox();
            VelConstante = new TextBox();
            TiempoDuracion = new Button();
            bCerrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(250, 55);
            label1.Name = "label1";
            label1.Size = new Size(174, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese a donde quiere viajar: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(250, 89);
            label2.Name = "label2";
            label2.Size = new Size(254, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingrese la distancia a recorrer en kilometros:";
            // 
            // VelocidadConstante
            // 
            VelocidadConstante.AutoSize = true;
            VelocidadConstante.BackColor = Color.Transparent;
            VelocidadConstante.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            VelocidadConstante.Location = new Point(250, 124);
            VelocidadConstante.Name = "VelocidadConstante";
            VelocidadConstante.Size = new Size(248, 15);
            VelocidadConstante.TabIndex = 2;
            VelocidadConstante.Text = "Ingrese la velocidad constante del vehiculo:";
            // 
            // LugarViaje
            // 
            LugarViaje.Location = new Point(510, 52);
            LugarViaje.Name = "LugarViaje";
            LugarViaje.Size = new Size(100, 23);
            LugarViaje.TabIndex = 3;
            LugarViaje.TextChanged += LugarViaje_TextChanged;
            // 
            // DistanciaKM
            // 
            DistanciaKM.Location = new Point(510, 81);
            DistanciaKM.Name = "DistanciaKM";
            DistanciaKM.Size = new Size(100, 23);
            DistanciaKM.TabIndex = 4;
            DistanciaKM.TextChanged += DistanciaKM_TextChanged;
            // 
            // VelConstante
            // 
            VelConstante.Location = new Point(510, 121);
            VelConstante.Name = "VelConstante";
            VelConstante.Size = new Size(100, 23);
            VelConstante.TabIndex = 5;
            VelConstante.TextChanged += VelConstante_TextChanged;
            // 
            // TiempoDuracion
            // 
            TiempoDuracion.BackColor = Color.Transparent;
            TiempoDuracion.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TiempoDuracion.Location = new Point(284, 180);
            TiempoDuracion.Name = "TiempoDuracion";
            TiempoDuracion.Size = new Size(238, 82);
            TiempoDuracion.TabIndex = 6;
            TiempoDuracion.Text = "CALCULAR DURACION DEL VIAJE";
            TiempoDuracion.UseVisualStyleBackColor = false;
            TiempoDuracion.Click += TiempoDuracion_Click;
            // 
            // bCerrar
            // 
            bCerrar.Location = new Point(345, 337);
            bCerrar.Name = "bCerrar";
            bCerrar.Size = new Size(132, 35);
            bCerrar.TabIndex = 7;
            bCerrar.Text = "CERRAR";
            bCerrar.UseVisualStyleBackColor = true;
            bCerrar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(bCerrar);
            Controls.Add(TiempoDuracion);
            Controls.Add(VelConstante);
            Controls.Add(DistanciaKM);
            Controls.Add(LugarViaje);
            Controls.Add(VelocidadConstante);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label VelocidadConstante;
        private TextBox LugarViaje;
        private TextBox DistanciaKM;
        private TextBox VelConstante;
        private Button TiempoDuracion;
        private Button bCerrar;
    }
}