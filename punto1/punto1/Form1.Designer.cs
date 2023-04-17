namespace punto1
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
            bCerrar = new Button();
            label1 = new Label();
            IngresoDatos = new TextBox();
            CalcularPerimetro = new Button();
            CalcularArea = new Button();
            Expresion = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // bCerrar
            // 
            resources.ApplyResources(bCerrar, "bCerrar");
            bCerrar.Name = "bCerrar";
            bCerrar.UseVisualStyleBackColor = true;
            bCerrar.Click += button1_Click;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // IngresoDatos
            // 
            resources.ApplyResources(IngresoDatos, "IngresoDatos");
            IngresoDatos.Name = "IngresoDatos";
            IngresoDatos.TextChanged += IngresoDatos_TextChanged;
            // 
            // CalcularPerimetro
            // 
            resources.ApplyResources(CalcularPerimetro, "CalcularPerimetro");
            CalcularPerimetro.Name = "CalcularPerimetro";
            CalcularPerimetro.UseVisualStyleBackColor = true;
            CalcularPerimetro.Click += CalcularPerimetro_Click;
            // 
            // CalcularArea
            // 
            resources.ApplyResources(CalcularArea, "CalcularArea");
            CalcularArea.Name = "CalcularArea";
            CalcularArea.UseVisualStyleBackColor = true;
            CalcularArea.Click += CalcularArea_Click;
            // 
            // Expresion
            // 
            resources.ApplyResources(Expresion, "Expresion");
            Expresion.Name = "Expresion";
            Expresion.TextChanged += Expresion_TextChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlText;
            label2.Name = "label2";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            Controls.Add(Expresion);
            Controls.Add(label2);
            Controls.Add(CalcularArea);
            Controls.Add(CalcularPerimetro);
            Controls.Add(IngresoDatos);
            Controls.Add(label1);
            Controls.Add(bCerrar);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bCerrar;
        private Label label1;
        private TextBox IngresoDatos;
        private Button CalcularPerimetro;
        private Button CalcularArea;
        private TextBox Expresion;
        private Label label2;
    }
}