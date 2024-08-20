namespace Aula2Forms
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.txtIndice = new System.Windows.Forms.TextBox();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labeeel = new System.Windows.Forms.Label();
            this.labelllll = new System.Windows.Forms.Label();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQdte = new System.Windows.Forms.Label();
            this.cboLista = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(488, 113);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(143, 20);
            this.txtTexto.TabIndex = 0;
            // 
            // txtIndice
            // 
            this.txtIndice.Location = new System.Drawing.Point(488, 439);
            this.txtIndice.Name = "txtIndice";
            this.txtIndice.Size = new System.Drawing.Size(143, 20);
            this.txtIndice.TabIndex = 1;
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(488, 484);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(143, 20);
            this.txtConteudo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Texto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lista";
            // 
            // labeeel
            // 
            this.labeeel.AutoSize = true;
            this.labeeel.Location = new System.Drawing.Point(393, 442);
            this.labeeel.Name = "labeeel";
            this.labeeel.Size = new System.Drawing.Size(89, 13);
            this.labeeel.TabIndex = 5;
            this.labeeel.Text = "Indice do combo:";
            // 
            // labelllll
            // 
            this.labelllll.AutoSize = true;
            this.labelllll.Location = new System.Drawing.Point(393, 487);
            this.labelllll.Name = "labelllll";
            this.labelllll.Size = new System.Drawing.Size(84, 13);
            this.labelllll.TabIndex = 6;
            this.labelllll.Text = "Texto do combo";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(450, 161);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(107, 23);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "Inserir no combo";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(579, 161);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(98, 23);
            this.btnOrdenar.TabIndex = 8;
            this.btnOrdenar.Text = "Ordenar o combo";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(513, 276);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(118, 23);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover do combo";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(513, 379);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(132, 23);
            this.btnExibir.TabIndex = 10;
            this.btnExibir.Text = "Exibir dados do combo";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quantidade de itens:";
            // 
            // lblQdte
            // 
            this.lblQdte.AutoSize = true;
            this.lblQdte.Location = new System.Drawing.Point(523, 332);
            this.lblQdte.Name = "lblQdte";
            this.lblQdte.Size = new System.Drawing.Size(13, 13);
            this.lblQdte.TabIndex = 12;
            this.lblQdte.Text = "0";
            // 
            // cboLista
            // 
            this.cboLista.FormattingEnabled = true;
            this.cboLista.Location = new System.Drawing.Point(476, 215);
            this.cboLista.Name = "cboLista";
            this.cboLista.Size = new System.Drawing.Size(245, 21);
            this.cboLista.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 586);
            this.Controls.Add(this.cboLista);
            this.Controls.Add(this.lblQdte);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.labelllll);
            this.Controls.Add(this.labeeel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.txtIndice);
            this.Controls.Add(this.txtTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.TextBox txtIndice;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labeeel;
        private System.Windows.Forms.Label labelllll;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblQdte;
        private System.Windows.Forms.ComboBox cboLista;
    }
}

