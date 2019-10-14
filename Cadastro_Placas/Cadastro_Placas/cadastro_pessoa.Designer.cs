/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 14/03/2018
 * Time: 01:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Cadastro_Placas
{
	partial class cadastro_pessoa
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
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.campo_nome = new System.Windows.Forms.TextBox();
			this.campo_cpf = new System.Windows.Forms.TextBox();
			this.campo_placa = new System.Windows.Forms.TextBox();
			this.campo_rg = new System.Windows.Forms.TextBox();
			this.botao_salvar = new System.Windows.Forms.Button();
			this.botao_deletar = new System.Windows.Forms.Button();
			this.botao_limpar = new System.Windows.Forms.Button();
			this.botao_pesquisar = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.listBox4 = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(22, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(22, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "CPF";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(22, 69);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "RG";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(22, 95);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Placa";
			// 
			// campo_nome
			// 
			this.campo_nome.Location = new System.Drawing.Point(66, 17);
			this.campo_nome.Name = "campo_nome";
			this.campo_nome.Size = new System.Drawing.Size(368, 20);
			this.campo_nome.TabIndex = 6;
			this.campo_nome.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// campo_cpf
			// 
			this.campo_cpf.Location = new System.Drawing.Point(66, 40);
			this.campo_cpf.Name = "campo_cpf";
			this.campo_cpf.Size = new System.Drawing.Size(151, 20);
			this.campo_cpf.TabIndex = 7;
			this.campo_cpf.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// campo_placa
			// 
			this.campo_placa.Location = new System.Drawing.Point(66, 92);
			this.campo_placa.Name = "campo_placa";
			this.campo_placa.Size = new System.Drawing.Size(77, 20);
			this.campo_placa.TabIndex = 9;
			this.campo_placa.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
			// 
			// campo_rg
			// 
			this.campo_rg.Location = new System.Drawing.Point(66, 66);
			this.campo_rg.Name = "campo_rg";
			this.campo_rg.Size = new System.Drawing.Size(151, 20);
			this.campo_rg.TabIndex = 8;
			this.campo_rg.TextChanged += new System.EventHandler(this.TextBox4TextChanged);
			// 
			// botao_salvar
			// 
			this.botao_salvar.Location = new System.Drawing.Point(560, 20);
			this.botao_salvar.Name = "botao_salvar";
			this.botao_salvar.Size = new System.Drawing.Size(75, 23);
			this.botao_salvar.TabIndex = 11;
			this.botao_salvar.Text = "Salvar";
			this.botao_salvar.UseVisualStyleBackColor = true;
			this.botao_salvar.Click += new System.EventHandler(this.Button1Click);
			// 
			// botao_deletar
			// 
			this.botao_deletar.Location = new System.Drawing.Point(560, 108);
			this.botao_deletar.Name = "botao_deletar";
			this.botao_deletar.Size = new System.Drawing.Size(75, 23);
			this.botao_deletar.TabIndex = 12;
			this.botao_deletar.Text = "Deletar";
			this.botao_deletar.UseVisualStyleBackColor = true;
			this.botao_deletar.Click += new System.EventHandler(this.Button2Click);
			// 
			// botao_limpar
			// 
			this.botao_limpar.Location = new System.Drawing.Point(560, 63);
			this.botao_limpar.Name = "botao_limpar";
			this.botao_limpar.Size = new System.Drawing.Size(75, 23);
			this.botao_limpar.TabIndex = 13;
			this.botao_limpar.Text = "Limpar";
			this.botao_limpar.UseVisualStyleBackColor = true;
			this.botao_limpar.Click += new System.EventHandler(this.Button3Click);
			// 
			// botao_pesquisar
			// 
			this.botao_pesquisar.Location = new System.Drawing.Point(220, 92);
			this.botao_pesquisar.Name = "botao_pesquisar";
			this.botao_pesquisar.Size = new System.Drawing.Size(75, 23);
			this.botao_pesquisar.TabIndex = 14;
			this.botao_pesquisar.Text = "Pesquisar";
			this.botao_pesquisar.UseVisualStyleBackColor = true;
			this.botao_pesquisar.Click += new System.EventHandler(this.Button4Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Items.AddRange(new object[] {
									"listbox1"});
			this.listBox1.Location = new System.Drawing.Point(12, 193);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 212);
			this.listBox1.TabIndex = 19;
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(138, 193);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(110, 212);
			this.listBox2.TabIndex = 20;
			// 
			// listBox3
			// 
			this.listBox3.FormattingEnabled = true;
			this.listBox3.Location = new System.Drawing.Point(254, 196);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(120, 212);
			this.listBox3.TabIndex = 21;
			// 
			// listBox4
			// 
			this.listBox4.FormattingEnabled = true;
			this.listBox4.Location = new System.Drawing.Point(380, 196);
			this.listBox4.Name = "listBox4";
			this.listBox4.Size = new System.Drawing.Size(120, 212);
			this.listBox4.TabIndex = 22;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(22, 167);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 23);
			this.label2.TabIndex = 24;
			this.label2.Text = "Placa";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(138, 167);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 23);
			this.label5.TabIndex = 25;
			this.label5.Text = "Proprietario";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(254, 167);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 23);
			this.label7.TabIndex = 26;
			this.label7.Text = "Cor";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(380, 167);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 23);
			this.label8.TabIndex = 27;
			this.label8.Text = "Modelo";
			// 
			// cadastro_pessoa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(677, 446);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBox4);
			this.Controls.Add(this.listBox3);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.botao_pesquisar);
			this.Controls.Add(this.botao_limpar);
			this.Controls.Add(this.botao_deletar);
			this.Controls.Add(this.botao_salvar);
			this.Controls.Add(this.campo_placa);
			this.Controls.Add(this.campo_rg);
			this.Controls.Add(this.campo_cpf);
			this.Controls.Add(this.campo_nome);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "cadastro_pessoa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "cadastro_pessoa";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Cadastro_pessoaLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listBox4;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button botao_pesquisar;
		private System.Windows.Forms.Button botao_limpar;
		private System.Windows.Forms.Button botao_deletar;
		private System.Windows.Forms.Button botao_salvar;
		private System.Windows.Forms.TextBox campo_rg;
		private System.Windows.Forms.TextBox campo_placa;
		private System.Windows.Forms.TextBox campo_cpf;
		private System.Windows.Forms.TextBox campo_nome;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
	}
}
