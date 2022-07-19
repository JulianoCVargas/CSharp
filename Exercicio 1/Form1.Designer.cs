namespace Exercicio_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNumero1 = new System.Windows.Forms.TextBox();
            this.txbNumero2 = new System.Windows.Forms.TextBox();
            this.txbNumero3 = new System.Windows.Forms.TextBox();
            this.txbNmaior = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNmenor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnImprima = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(56, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(56, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero 3:";
            // 
            // txbNumero1
            // 
            this.txbNumero1.Location = new System.Drawing.Point(211, 70);
            this.txbNumero1.Name = "txbNumero1";
            this.txbNumero1.Size = new System.Drawing.Size(100, 23);
            this.txbNumero1.TabIndex = 3;
            // 
            // txbNumero2
            // 
            this.txbNumero2.Location = new System.Drawing.Point(211, 149);
            this.txbNumero2.Name = "txbNumero2";
            this.txbNumero2.Size = new System.Drawing.Size(100, 23);
            this.txbNumero2.TabIndex = 4;
            this.txbNumero2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txbNumero3
            // 
            this.txbNumero3.Location = new System.Drawing.Point(211, 239);
            this.txbNumero3.Name = "txbNumero3";
            this.txbNumero3.Size = new System.Drawing.Size(100, 23);
            this.txbNumero3.TabIndex = 5;
            // 
            // txbNmaior
            // 
            this.txbNmaior.Location = new System.Drawing.Point(635, 123);
            this.txbNmaior.Name = "txbNmaior";
            this.txbNmaior.Size = new System.Drawing.Size(120, 23);
            this.txbNmaior.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(461, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Numero Maior:";
            // 
            // txbNmenor
            // 
            this.txbNmenor.Location = new System.Drawing.Point(635, 174);
            this.txbNmenor.Name = "txbNmenor";
            this.txbNmenor.Size = new System.Drawing.Size(120, 23);
            this.txbNmenor.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(459, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Numero Menor:";
            // 
            // btnImprima
            // 
            this.btnImprima.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnImprima.Location = new System.Drawing.Point(339, 65);
            this.btnImprima.Name = "btnImprima";
            this.btnImprima.Size = new System.Drawing.Size(90, 195);
            this.btnImprima.TabIndex = 10;
            this.btnImprima.Text = "Imprima";
            this.btnImprima.UseVisualStyleBackColor = true;
            this.btnImprima.Click += new System.EventHandler(this.btnImprima_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 308);
            this.Controls.Add(this.btnImprima);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbNmenor);
            this.Controls.Add(this.txbNmaior);
            this.Controls.Add(this.txbNumero3);
            this.Controls.Add(this.txbNumero2);
            this.Controls.Add(this.txbNumero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txbNumero1;
        private TextBox txbNumero2;
        private TextBox txbNumero3;
        private TextBox txbNmaior;
        private Label label4;
        private TextBox txbNmenor;
        private Label label5;
        private Button btnImprima;
    }
}