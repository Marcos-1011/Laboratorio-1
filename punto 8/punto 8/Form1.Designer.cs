namespace punto_8
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
            button1 = new Button();
            NumA = new TextBox();
            NumB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            bCerrar = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(281, 273);
            button1.Name = "button1";
            button1.Size = new Size(168, 49);
            button1.TabIndex = 0;
            button1.Text = "INTERCAMBIAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NumA
            // 
            NumA.Location = new Point(349, 65);
            NumA.Name = "NumA";
            NumA.Size = new Size(100, 23);
            NumA.TabIndex = 1;
            // 
            // NumB
            // 
            NumB.Location = new Point(349, 106);
            NumB.Name = "NumB";
            NumB.Size = new Size(100, 23);
            NumB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(230, 68);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 3;
            label1.Text = "Ingrese numero A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 109);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 4;
            label2.Text = "Ingrese numero B";
            // 
            // bCerrar
            // 
            bCerrar.Location = new Point(703, 397);
            bCerrar.Name = "bCerrar";
            bCerrar.Size = new Size(85, 41);
            bCerrar.TabIndex = 5;
            bCerrar.Text = "Cerrar";
            bCerrar.UseVisualStyleBackColor = true;
            bCerrar.Click += bCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bCerrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NumB);
            Controls.Add(NumA);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Ingrese numero A";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox NumA;
        private TextBox NumB;
        private Label label1;
        private Label label2;
        private Button bCerrar;
    }
}