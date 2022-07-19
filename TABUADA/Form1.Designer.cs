namespace TABUADA
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
            this.btnTabuada = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lsbTabuada = new System.Windows.Forms.ListBox();
            this.txbNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(43, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe um Número";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTabuada
            // 
            this.btnTabuada.Font = new System.Drawing.Font("Elephant", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTabuada.Location = new System.Drawing.Point(270, 145);
            this.btnTabuada.Name = "btnTabuada";
            this.btnTabuada.Size = new System.Drawing.Size(140, 48);
            this.btnTabuada.TabIndex = 1;
            this.btnTabuada.Text = "TABUADA";
            this.btnTabuada.UseVisualStyleBackColor = true;
            this.btnTabuada.Click += new System.EventHandler(this.button1_Click);
            this.btnTabuada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnTabuada_KeyDown);
            this.btnTabuada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnTabuada_KeyPress);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Elephant", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLimpar.Location = new System.Drawing.Point(270, 247);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(140, 48);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Elephant", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(270, 348);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(140, 48);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnTabuada_KeyPress);
            // 
            // lsbTabuada
            // 
            this.lsbTabuada.FormattingEnabled = true;
            this.lsbTabuada.ItemHeight = 15;
            this.lsbTabuada.Location = new System.Drawing.Point(43, 108);
            this.lsbTabuada.Name = "lsbTabuada";
            this.lsbTabuada.Size = new System.Drawing.Size(194, 379);
            this.lsbTabuada.TabIndex = 4;
            // 
            // txbNum
            // 
            this.txbNum.Location = new System.Drawing.Point(214, 53);
            this.txbNum.Name = "txbNum";
            this.txbNum.Size = new System.Drawing.Size(56, 23);
            this.txbNum.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 521);
            this.Controls.Add(this.txbNum);
            this.Controls.Add(this.lsbTabuada);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnTabuada);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnTabuada;
        private Button btnLimpar;
        private Button btnSair;
        private ListBox lsbTabuada;
        private TextBox txbNum;
    }
}