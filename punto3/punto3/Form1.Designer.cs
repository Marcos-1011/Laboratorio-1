namespace punto3
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
            label3 = new Label();
            AnchoPared = new TextBox();
            AltoPared = new TextBox();
            m3 = new TextBox();
            button1 = new Button();
            bCerrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(197, 55);
            label1.Name = "label1";
            label1.Size = new Size(212, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el ancho de la pared: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(197, 100);
            label2.Name = "label2";
            label2.Size = new Size(197, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese el alto de la pared: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(197, 138);
            label3.Name = "label3";
            label3.Size = new Size(274, 20);
            label3.TabIndex = 2;
            label3.Text = "Ingrese los m3 por metros cuadrados:";
            // 
            // AnchoPared
            // 
            AnchoPared.Location = new Point(477, 52);
            AnchoPared.Name = "AnchoPared";
            AnchoPared.Size = new Size(100, 23);
            AnchoPared.TabIndex = 3;
            AnchoPared.TextChanged += AnchoPared_TextChanged;
            // 
            // AltoPared
            // 
            AltoPared.Location = new Point(477, 97);
            AltoPared.Name = "AltoPared";
            AltoPared.Size = new Size(100, 23);
            AltoPared.TabIndex = 4;
            AltoPared.TextChanged += AltoPared_TextChanged;
            // 
            // m3
            // 
            m3.Location = new Point(477, 138);
            m3.Name = "m3";
            m3.Size = new Size(100, 23);
            m3.TabIndex = 5;
            m3.TextChanged += m3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(234, 207);
            button1.Name = "button1";
            button1.Size = new Size(269, 135);
            button1.TabIndex = 6;
            button1.Text = "CALCULAR LOS M3";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bCerrar
            // 
            bCerrar.Location = new Point(338, 364);
            bCerrar.Name = "bCerrar";
            bCerrar.Size = new Size(77, 36);
            bCerrar.TabIndex = 7;
            bCerrar.Text = "CERRAR";
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
            Controls.Add(m3);
            Controls.Add(AltoPared);
            Controls.Add(AnchoPared);
            Controls.Add(label3);
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
        private Label label3;
        private TextBox AnchoPared;
        private TextBox AltoPared;
        private TextBox m3;
        private Button button1;
        private Button bCerrar;
    }
}