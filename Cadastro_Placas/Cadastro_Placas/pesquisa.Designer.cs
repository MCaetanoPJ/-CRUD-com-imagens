/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 09/03/2018
 * Time: 18:38
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Cadastro_Placas
{
	partial class pesquisa
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
			this.campo_placa = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.proprietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipo_veiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.multa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label2 = new System.Windows.Forms.Label();
			this.campo_proprietario = new System.Windows.Forms.TextBox();
			this.botao_pesquisar = new System.Windows.Forms.Button();
			this.botao_alterar = new System.Windows.Forms.Button();
			this.botao_limpar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Placa";
			// 
			// campo_placa
			// 
			this.campo_placa.Location = new System.Drawing.Point(103, 23);
			this.campo_placa.Name = "campo_placa";
			this.campo_placa.Size = new System.Drawing.Size(100, 20);
			this.campo_placa.TabIndex = 1;
			this.campo_placa.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.placa,
									this.proprietario,
									this.cor,
									this.modelo,
									this.tipo_veiculo,
									this.multa});
			this.dataGridView1.Location = new System.Drawing.Point(12, 128);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(650, 270);
			this.dataGridView1.TabIndex = 19;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// placa
			// 
			this.placa.HeaderText = "placa";
			this.placa.Name = "placa";
			this.placa.ReadOnly = true;
			// 
			// proprietario
			// 
			this.proprietario.HeaderText = "proprietario";
			this.proprietario.Name = "proprietario";
			this.proprietario.ReadOnly = true;
			// 
			// cor
			// 
			this.cor.HeaderText = "cor";
			this.cor.Name = "cor";
			this.cor.ReadOnly = true;
			// 
			// modelo
			// 
			this.modelo.HeaderText = "modelo";
			this.modelo.Name = "modelo";
			this.modelo.ReadOnly = true;
			// 
			// tipo_veiculo
			// 
			this.tipo_veiculo.HeaderText = "tipo_veiculo";
			this.tipo_veiculo.Name = "tipo_veiculo";
			this.tipo_veiculo.ReadOnly = true;
			// 
			// multa
			// 
			this.multa.HeaderText = "multa";
			this.multa.Name = "multa";
			this.multa.ReadOnly = true;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 23);
			this.label2.TabIndex = 20;
			this.label2.Text = "Proprietario";
			// 
			// campo_proprietario
			// 
			this.campo_proprietario.Location = new System.Drawing.Point(103, 46);
			this.campo_proprietario.Name = "campo_proprietario";
			this.campo_proprietario.Size = new System.Drawing.Size(323, 20);
			this.campo_proprietario.TabIndex = 21;
			this.campo_proprietario.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// botao_pesquisar
			// 
			this.botao_pesquisar.Location = new System.Drawing.Point(128, 87);
			this.botao_pesquisar.Name = "botao_pesquisar";
			this.botao_pesquisar.Size = new System.Drawing.Size(75, 23);
			this.botao_pesquisar.TabIndex = 24;
			this.botao_pesquisar.Text = "Pesquisar";
			this.botao_pesquisar.UseVisualStyleBackColor = true;
			this.botao_pesquisar.Click += new System.EventHandler(this.Button1Click);
			// 
			// botao_alterar
			// 
			this.botao_alterar.Location = new System.Drawing.Point(228, 87);
			this.botao_alterar.Name = "botao_alterar";
			this.botao_alterar.Size = new System.Drawing.Size(75, 23);
			this.botao_alterar.TabIndex = 25;
			this.botao_alterar.Text = "Alterar";
			this.botao_alterar.UseVisualStyleBackColor = true;
			this.botao_alterar.Click += new System.EventHandler(this.Button2Click);
			// 
			// botao_limpar
			// 
			this.botao_limpar.Location = new System.Drawing.Point(331, 87);
			this.botao_limpar.Name = "botao_limpar";
			this.botao_limpar.Size = new System.Drawing.Size(75, 23);
			this.botao_limpar.TabIndex = 26;
			this.botao_limpar.Text = "Limpar";
			this.botao_limpar.UseVisualStyleBackColor = true;
			this.botao_limpar.Click += new System.EventHandler(this.Button3Click);
			// 
			// pesquisa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(669, 410);
			this.Controls.Add(this.botao_limpar);
			this.Controls.Add(this.botao_alterar);
			this.Controls.Add(this.botao_pesquisar);
			this.Controls.Add(this.campo_proprietario);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.campo_placa);
			this.Controls.Add(this.label1);
			this.Name = "pesquisa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "pesquisa";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.PesquisaLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button botao_limpar;
		private System.Windows.Forms.Button botao_alterar;
		private System.Windows.Forms.Button botao_pesquisar;
		private System.Windows.Forms.DataGridViewTextBoxColumn multa;
		private System.Windows.Forms.TextBox campo_proprietario;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipo_veiculo;
		private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
		private System.Windows.Forms.DataGridViewTextBoxColumn cor;
		private System.Windows.Forms.DataGridViewTextBoxColumn proprietario;
		private System.Windows.Forms.DataGridViewTextBoxColumn placa;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox campo_placa;
		private System.Windows.Forms.Label label1;
	}
}
