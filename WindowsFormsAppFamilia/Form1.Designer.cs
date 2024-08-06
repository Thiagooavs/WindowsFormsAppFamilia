namespace WindowsFormsAppFamilia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Grana = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_outro = new System.Windows.Forms.TextBox();
            this.txt_Alimentacao = new System.Windows.Forms.TextBox();
            this.txt_TV = new System.Windows.Forms.TextBox();
            this.txt_Agua = new System.Windows.Forms.TextBox();
            this.txt_Energia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bnt_Calcular = new System.Windows.Forms.Button();
            this.bnt_Limpar = new System.Windows.Forms.Button();
            this.bnt_Fechar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Saldo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renda Familiar:";
            // 
            // txt_Grana
            // 
            this.txt_Grana.Location = new System.Drawing.Point(98, 33);
            this.txt_Grana.Name = "txt_Grana";
            this.txt_Grana.Size = new System.Drawing.Size(100, 20);
            this.txt_Grana.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_outro);
            this.groupBox1.Controls.Add(this.txt_Alimentacao);
            this.groupBox1.Controls.Add(this.txt_TV);
            this.groupBox1.Controls.Add(this.txt_Agua);
            this.groupBox1.Controls.Add(this.txt_Energia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(70, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 219);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txt_outro
            // 
            this.txt_outro.Location = new System.Drawing.Point(124, 152);
            this.txt_outro.Name = "txt_outro";
            this.txt_outro.Size = new System.Drawing.Size(100, 20);
            this.txt_outro.TabIndex = 9;
            // 
            // txt_Alimentacao
            // 
            this.txt_Alimentacao.Location = new System.Drawing.Point(124, 120);
            this.txt_Alimentacao.Name = "txt_Alimentacao";
            this.txt_Alimentacao.Size = new System.Drawing.Size(100, 20);
            this.txt_Alimentacao.TabIndex = 8;
            // 
            // txt_TV
            // 
            this.txt_TV.Location = new System.Drawing.Point(124, 87);
            this.txt_TV.Name = "txt_TV";
            this.txt_TV.Size = new System.Drawing.Size(100, 20);
            this.txt_TV.TabIndex = 7;
            // 
            // txt_Agua
            // 
            this.txt_Agua.Location = new System.Drawing.Point(124, 55);
            this.txt_Agua.Name = "txt_Agua";
            this.txt_Agua.Size = new System.Drawing.Size(100, 20);
            this.txt_Agua.TabIndex = 6;
            // 
            // txt_Energia
            // 
            this.txt_Energia.Location = new System.Drawing.Point(124, 28);
            this.txt_Energia.Name = "txt_Energia";
            this.txt_Energia.Size = new System.Drawing.Size(100, 20);
            this.txt_Energia.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Outros Gastos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Alimentação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "TV/FONE/Internete:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Água:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Energia Elétrica:";
            // 
            // bnt_Calcular
            // 
            this.bnt_Calcular.Location = new System.Drawing.Point(51, 320);
            this.bnt_Calcular.Name = "bnt_Calcular";
            this.bnt_Calcular.Size = new System.Drawing.Size(75, 23);
            this.bnt_Calcular.TabIndex = 3;
            this.bnt_Calcular.Text = "Calcular";
            this.bnt_Calcular.UseVisualStyleBackColor = true;
            this.bnt_Calcular.Click += new System.EventHandler(this.bnt_Calcular_Click);
            // 
            // bnt_Limpar
            // 
            this.bnt_Limpar.Location = new System.Drawing.Point(149, 320);
            this.bnt_Limpar.Name = "bnt_Limpar";
            this.bnt_Limpar.Size = new System.Drawing.Size(75, 23);
            this.bnt_Limpar.TabIndex = 4;
            this.bnt_Limpar.Text = "Limpar";
            this.bnt_Limpar.UseVisualStyleBackColor = true;
            this.bnt_Limpar.Click += new System.EventHandler(this.bnt_Limpar_Click);
            // 
            // bnt_Fechar
            // 
            this.bnt_Fechar.Location = new System.Drawing.Point(258, 319);
            this.bnt_Fechar.Name = "bnt_Fechar";
            this.bnt_Fechar.Size = new System.Drawing.Size(75, 23);
            this.bnt_Fechar.TabIndex = 5;
            this.bnt_Fechar.Text = "Fechar";
            this.bnt_Fechar.UseVisualStyleBackColor = true;
            this.bnt_Fechar.Click += new System.EventHandler(this.bnt_Fechar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total de gastos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Saldo:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(145, 361);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(13, 13);
            this.lbl_Total.TabIndex = 8;
            this.lbl_Total.Text = "0";
            // 
            // lbl_Saldo
            // 
            this.lbl_Saldo.AutoSize = true;
            this.lbl_Saldo.Location = new System.Drawing.Point(129, 395);
            this.lbl_Saldo.Name = "lbl_Saldo";
            this.lbl_Saldo.Size = new System.Drawing.Size(13, 13);
            this.lbl_Saldo.TabIndex = 9;
            this.lbl_Saldo.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Saldo);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bnt_Fechar);
            this.Controls.Add(this.bnt_Limpar);
            this.Controls.Add(this.bnt_Calcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Grana);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Grana;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_outro;
        private System.Windows.Forms.TextBox txt_Alimentacao;
        private System.Windows.Forms.TextBox txt_TV;
        private System.Windows.Forms.TextBox txt_Agua;
        private System.Windows.Forms.TextBox txt_Energia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnt_Calcular;
        private System.Windows.Forms.Button bnt_Limpar;
        private System.Windows.Forms.Button bnt_Fechar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Saldo;
    }
}

