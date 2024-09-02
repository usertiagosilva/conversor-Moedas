
namespace ConversorDeMoedas
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
            txtValor = new TextBox();
            cmbMoedaOrigem = new ComboBox();
            cmbMoedaDestino = new ComboBox();
            btnConverter = new Button();
            lblResultado = new Label();
            label1 = new Label();
            label2 = new Label();
            btnLimpar = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtValor
            // 
            txtValor.Location = new Point(199, 37);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(125, 27);
            txtValor.TabIndex = 0;
            txtValor.TextAlign = HorizontalAlignment.Right;
            // 
            // cmbMoedaOrigem
            // 
            cmbMoedaOrigem.FormattingEnabled = true;
            cmbMoedaOrigem.Items.AddRange(new object[] { "EUR", "USD", "BRL" });
            cmbMoedaOrigem.Location = new Point(276, 233);
            cmbMoedaOrigem.Name = "cmbMoedaOrigem";
            cmbMoedaOrigem.Size = new Size(151, 28);
            cmbMoedaOrigem.TabIndex = 1;
            // 
            // cmbMoedaDestino
            // 
            cmbMoedaDestino.FormattingEnabled = true;
            cmbMoedaDestino.Location = new Point(276, 299);
            cmbMoedaDestino.Name = "cmbMoedaDestino";
            cmbMoedaDestino.Size = new Size(151, 28);
            cmbMoedaDestino.TabIndex = 2;
            // 
            // btnConverter
            // 
            btnConverter.Location = new Point(160, 368);
            btnConverter.Name = "btnConverter";
            btnConverter.Size = new Size(94, 29);
            btnConverter.TabIndex = 3;
            btnConverter.Text = "Converter";
            btnConverter.UseVisualStyleBackColor = true;
            btnConverter.Click += btnConverter_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(105, 78);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(78, 20);
            lblResultado.TabIndex = 4;
            lblResultado.Text = "Resultado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 241);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 5;
            label1.Text = "Moeda de origem:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 307);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 6;
            label2.Text = "Moeda de destino:";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(305, 368);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 37);
            label3.Name = "label3";
            label3.Size = new Size(146, 20);
            label3.TabIndex = 8;
            label3.Text = "Valor para converter:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 435);
            Controls.Add(label3);
            Controls.Add(btnLimpar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResultado);
            Controls.Add(btnConverter);
            Controls.Add(cmbMoedaDestino);
            Controls.Add(cmbMoedaOrigem);
            Controls.Add(txtValor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e) => throw new NotImplementedException();

        #endregion

        private TextBox txtValor;
        private ComboBox cmbMoedaOrigem;
        private ComboBox cmbMoedaDestino;
        private Button btnConverter;
        private Label lblResultado;
        private Label label1;
        private Label label2;
        private Button btnLimpar;
        private Label label3;
    }
}
