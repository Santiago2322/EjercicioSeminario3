namespace EjercicioSeminario3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button button1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(30, 160);
            label1.Name = "label1";
            label1.Size = new Size(300, 200);
            label1.TabIndex = 3;
            label1.Text = "Resultado";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(30, 110);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 2;
            button1.Text = "Calcular Vuelto";
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(400, 400);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculadora de Vuelto";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}


