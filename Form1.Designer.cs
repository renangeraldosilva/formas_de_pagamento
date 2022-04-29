namespace Aula40
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.lblParcelasTexto = new System.Windows.Forms.Label();
            this.txtNumeroParcelas = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxParcelas = new System.Windows.Forms.ListBox();
            this.lblChavePix = new System.Windows.Forms.Label();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(59, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formas de pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Metodo de pagamento foi:";
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Location = new System.Drawing.Point(239, 244);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(0, 13);
            this.lblEscolha.TabIndex = 3;
            // 
            // lblParcelasTexto
            // 
            this.lblParcelasTexto.AutoSize = true;
            this.lblParcelasTexto.Location = new System.Drawing.Point(15, 315);
            this.lblParcelasTexto.Name = "lblParcelasTexto";
            this.lblParcelasTexto.Size = new System.Drawing.Size(188, 13);
            this.lblParcelasTexto.TabIndex = 5;
            this.lblParcelasTexto.Text = "Em Quantas vezes você quer parcelar";
            this.lblParcelasTexto.Visible = false;
            // 
            // txtNumeroParcelas
            // 
            this.txtNumeroParcelas.Location = new System.Drawing.Point(209, 315);
            this.txtNumeroParcelas.Name = "txtNumeroParcelas";
            this.txtNumeroParcelas.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroParcelas.TabIndex = 6;
            this.txtNumeroParcelas.Visible = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(209, 341);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Visible = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(132, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor do Produto";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(262, 62);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 9;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "R$";
            // 
            // listBoxParcelas
            // 
            this.listBoxParcelas.FormattingEnabled = true;
            this.listBoxParcelas.Location = new System.Drawing.Point(387, 233);
            this.listBoxParcelas.Name = "listBoxParcelas";
            this.listBoxParcelas.Size = new System.Drawing.Size(120, 199);
            this.listBoxParcelas.TabIndex = 10;
            // 
            // lblChavePix
            // 
            this.lblChavePix.AutoSize = true;
            this.lblChavePix.Location = new System.Drawing.Point(157, 296);
            this.lblChavePix.Name = "lblChavePix";
            this.lblChavePix.Size = new System.Drawing.Size(169, 13);
            this.lblChavePix.TabIndex = 11;
            this.lblChavePix.Text = "A Chave Pix para o pagamento é: ";
            this.lblChavePix.Visible = false;
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(332, 296);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(223, 20);
            this.txtChave.TabIndex = 12;
            this.txtChave.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.lblChavePix);
            this.Controls.Add(this.listBoxParcelas);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumeroParcelas);
            this.Controls.Add(this.lblParcelasTexto);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.Label lblParcelasTexto;
        private System.Windows.Forms.TextBox txtNumeroParcelas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxParcelas;
        private System.Windows.Forms.Label lblChavePix;
        private System.Windows.Forms.TextBox txtChave;
    }
}

