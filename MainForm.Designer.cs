/*
 * Criado por SharpDevelop.
 * Usuário: m31692
 * Data: 1/11/2007
 * Hora: 23:05
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace PartCnj
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.btnRun = new System.Windows.Forms.Button();
            this.txtPopulacao = new System.Windows.Forms.TextBox();
            this.txtIteracoes = new System.Windows.Forms.TextBox();
            this.txtMinGrupos = new System.Windows.Forms.TextBox();
            this.txtMaxGrupos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSimAne = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(253, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(195, 33);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "&Executa com Algoritmo Genético";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPopulacao
            // 
            this.txtPopulacao.Location = new System.Drawing.Point(110, 12);
            this.txtPopulacao.Name = "txtPopulacao";
            this.txtPopulacao.Size = new System.Drawing.Size(113, 20);
            this.txtPopulacao.TabIndex = 1;
            this.txtPopulacao.Text = "50";
            // 
            // txtIteracoes
            // 
            this.txtIteracoes.Location = new System.Drawing.Point(110, 38);
            this.txtIteracoes.Name = "txtIteracoes";
            this.txtIteracoes.Size = new System.Drawing.Size(113, 20);
            this.txtIteracoes.TabIndex = 2;
            this.txtIteracoes.Text = "100";
            // 
            // txtMinGrupos
            // 
            this.txtMinGrupos.Location = new System.Drawing.Point(110, 64);
            this.txtMinGrupos.Name = "txtMinGrupos";
            this.txtMinGrupos.Size = new System.Drawing.Size(113, 20);
            this.txtMinGrupos.TabIndex = 3;
            this.txtMinGrupos.Text = "2";
            // 
            // txtMaxGrupos
            // 
            this.txtMaxGrupos.Location = new System.Drawing.Point(110, 90);
            this.txtMaxGrupos.Name = "txtMaxGrupos";
            this.txtMaxGrupos.Size = new System.Drawing.Size(113, 20);
            this.txtMaxGrupos.TabIndex = 4;
            this.txtMaxGrupos.Text = "6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "População a gerar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Iterações";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Min. Grupos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Max. Grupos";
            // 
            // btnSimAne
            // 
            this.btnSimAne.Location = new System.Drawing.Point(253, 51);
            this.btnSimAne.Name = "btnSimAne";
            this.btnSimAne.Size = new System.Drawing.Size(195, 33);
            this.btnSimAne.TabIndex = 9;
            this.btnSimAne.Text = "Executa com Simulated Annealing";
            this.btnSimAne.UseVisualStyleBackColor = true;
            this.btnSimAne.Click += new System.EventHandler(this.btnSimAne_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 14);
            this.label5.TabIndex = 10;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(339, 209);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(126, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Gustavo Augusto Hennig";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "Alterar Matriz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 231);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSimAne);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaxGrupos);
            this.Controls.Add(this.txtMinGrupos);
            this.Controls.Add(this.txtIteracoes);
            this.Controls.Add(this.txtPopulacao);
            this.Controls.Add(this.btnRun);
            this.Name = "MainForm";
            this.Text = "Particionamento de Conjuntos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtPopulacao;
        private System.Windows.Forms.TextBox txtIteracoes;
        private System.Windows.Forms.TextBox txtMinGrupos;
        private System.Windows.Forms.TextBox txtMaxGrupos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSimAne;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
	}
}
