namespace caculadora
{
    partial class calculadora
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
            label1 = new Label();
            txtNumero1 = new TextBox();
            label2 = new Label();
            txtNumero2 = new TextBox();
            btnSubitrair = new Button();
            btnSomar = new Button();
            button2 = new Button();
            button3 = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "numero 1";
            label1.Click += label1_Click;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(16, 48);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 1;
            txtNumero1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 30);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "numero 2";
            label2.Click += label2_Click;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(232, 48);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 3;
            txtNumero2.TextChanged += txtNumero2_TextChanged;
            // 
            // btnSubitrair
            // 
            btnSubitrair.Location = new Point(120, 104);
            btnSubitrair.Name = "btnSubitrair";
            btnSubitrair.Size = new Size(75, 23);
            btnSubitrair.TabIndex = 4;
            btnSubitrair.Text = "subitrair";
            btnSubitrair.UseVisualStyleBackColor = true;
            btnSubitrair.Click += somar_Click;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(8, 104);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(75, 23);
            btnSomar.TabIndex = 5;
            btnSomar.Text = "somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(224, 104);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "multiplicar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(328, 104);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "dividir";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(416, 40);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(28, 32);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "0";
            // 
            // calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 171);
            Controls.Add(lblResultado);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnSomar);
            Controls.Add(btnSubitrair);
            Controls.Add(txtNumero2);
            Controls.Add(label2);
            Controls.Add(txtNumero1);
            Controls.Add(label1);
            Name = "calculadora";
            Text = "calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero1;
        private Label label2;
        private TextBox txtNumero2;
        private Button btnSubitrair;
        private Button btnSomar;
        private Button button2;
        private Button button3;
        private Label lblResultado;
    }
}
