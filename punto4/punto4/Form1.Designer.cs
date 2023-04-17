namespace punto4
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
            NombreArchivo = new TextBox();
            TamanoArchivo = new TextBox();
            button1 = new Button();
            bCerrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(291, 131);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre de archivo";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(288, 169);
            label2.Name = "label2";
            label2.Size = new Size(149, 20);
            label2.TabIndex = 1;
            label2.Text = "tamano del archivo";
            // 
            // NombreArchivo
            // 
            NombreArchivo.Location = new Point(443, 128);
            NombreArchivo.Name = "NombreArchivo";
            NombreArchivo.Size = new Size(100, 23);
            NombreArchivo.TabIndex = 2;
            NombreArchivo.TextChanged += NombreArchivo_TextChanged;
            // 
            // TamanoArchivo
            // 
            TamanoArchivo.Location = new Point(443, 170);
            TamanoArchivo.Name = "TamanoArchivo";
            TamanoArchivo.Size = new Size(100, 23);
            TamanoArchivo.TabIndex = 3;
            TamanoArchivo.TextChanged += TamanoArchivo_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(212, 250);
            button1.Name = "button1";
            button1.Size = new Size(160, 61);
            button1.TabIndex = 4;
            button1.Text = "Calcular tamano";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bCerrar
            // 
            bCerrar.Location = new Point(470, 250);
            bCerrar.Name = "bCerrar";
            bCerrar.Size = new Size(160, 61);
            bCerrar.TabIndex = 5;
            bCerrar.Text = "Cerrar";
            bCerrar.UseVisualStyleBackColor = true;
            bCerrar.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(bCerrar);
            Controls.Add(button1);
            Controls.Add(TamanoArchivo);
            Controls.Add(NombreArchivo);
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
        private TextBox NombreArchivo;
        private TextBox TamanoArchivo;
        private Button button1;
        private Button bCerrar;
    }
}