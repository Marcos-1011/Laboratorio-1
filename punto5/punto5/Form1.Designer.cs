namespace punto5
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
            NombreCliente = new TextBox();
            ValorPagado = new TextBox();
            ValorCompra = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            bCerrar = new Button();
            SuspendLayout();
            // 
            // NombreCliente
            // 
            NombreCliente.Location = new Point(448, 66);
            NombreCliente.Name = "NombreCliente";
            NombreCliente.Size = new Size(100, 23);
            NombreCliente.TabIndex = 0;
            NombreCliente.TextChanged += NombreCliente_TextChanged;
            // 
            // ValorPagado
            // 
            ValorPagado.Location = new Point(448, 159);
            ValorPagado.Name = "ValorPagado";
            ValorPagado.Size = new Size(100, 23);
            ValorPagado.TabIndex = 1;
            ValorPagado.TextChanged += ValorPagado_TextChanged;
            // 
            // ValorCompra
            // 
            ValorCompra.Location = new Point(448, 116);
            ValorCompra.Name = "ValorCompra";
            ValorCompra.Size = new Size(100, 23);
            ValorCompra.TabIndex = 2;
            ValorCompra.TextChanged += ValorCompra_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(254, 67);
            label1.Name = "label1";
            label1.Size = new Size(188, 17);
            label1.TabIndex = 3;
            label1.Text = "Ingrese el nombre del cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(254, 117);
            label2.Name = "label2";
            label2.Size = new Size(194, 17);
            label2.TabIndex = 4;
            label2.Text = "Ingrese el precio de la compra";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(254, 159);
            label3.Name = "label3";
            label3.Size = new Size(159, 17);
            label3.TabIndex = 5;
            label3.Text = "Ingrese con cuanto paga";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(304, 248);
            button1.Name = "button1";
            button1.Size = new Size(188, 60);
            button1.TabIndex = 6;
            button1.Text = "Calcular vuelto";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // bCerrar
            // 
            bCerrar.BackColor = SystemColors.ActiveCaptionText;
            bCerrar.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bCerrar.ForeColor = SystemColors.ControlLightLight;
            bCerrar.Location = new Point(304, 358);
            bCerrar.Name = "bCerrar";
            bCerrar.Size = new Size(188, 32);
            bCerrar.TabIndex = 7;
            bCerrar.Text = "Cerrar";
            bCerrar.UseVisualStyleBackColor = false;
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
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ValorCompra);
            Controls.Add(ValorPagado);
            Controls.Add(NombreCliente);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NombreCliente;
        private TextBox ValorPagado;
        private TextBox ValorCompra;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button bCerrar;
    }
}