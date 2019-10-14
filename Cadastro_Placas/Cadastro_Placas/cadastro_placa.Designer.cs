/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 09/03/2018
 * Time: 17:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Cadastro_Placas
{
	partial class cadastro_placa
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.campo_modelo = new System.Windows.Forms.TextBox();
			this.campo_ano = new System.Windows.Forms.TextBox();
			this.campo_cor = new System.Windows.Forms.TextBox();
			this.campo_proprietario = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.campo_placa = new System.Windows.Forms.TextBox();
			this.botao_importar = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.botao_limpar = new System.Windows.Forms.Button();
			this.botao_deletar = new System.Windows.Forms.Button();
			this.botao_salvar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.proprietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tipo_veiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.campo_tipo_veiculo = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(23, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tipo de Veiculo";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(23, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Ano";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(23, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Modelo";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(23, 99);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Cor";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(23, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Proprietario";
			// 
			// campo_modelo
			// 
			this.campo_modelo.Location = new System.Drawing.Point(115, 44);
			this.campo_modelo.Name = "campo_modelo";
			this.campo_modelo.Size = new System.Drawing.Size(291, 20);
			this.campo_modelo.TabIndex = 6;
			this.campo_modelo.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// campo_ano
			// 
			this.campo_ano.Location = new System.Drawing.Point(115, 70);
			this.campo_ano.Name = "campo_ano";
			this.campo_ano.Size = new System.Drawing.Size(85, 20);
			this.campo_ano.TabIndex = 7;
			this.campo_ano.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// campo_cor
			// 
			this.campo_cor.Location = new System.Drawing.Point(115, 96);
			this.campo_cor.Name = "campo_cor";
			this.campo_cor.Size = new System.Drawing.Size(85, 20);
			this.campo_cor.TabIndex = 8;
			this.campo_cor.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
			// 
			// campo_proprietario
			// 
			this.campo_proprietario.Location = new System.Drawing.Point(115, 122);
			this.campo_proprietario.Name = "campo_proprietario";
			this.campo_proprietario.Size = new System.Drawing.Size(291, 20);
			this.campo_proprietario.TabIndex = 9;
			this.campo_proprietario.TextChanged += new System.EventHandler(this.TextBox4TextChanged);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(23, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 10;
			this.label6.Text = "Placa";
			// 
			// campo_placa
			// 
			this.campo_placa.Location = new System.Drawing.Point(115, 149);
			this.campo_placa.Name = "campo_placa";
			this.campo_placa.Size = new System.Drawing.Size(85, 20);
			this.campo_placa.TabIndex = 11;
			// 
			// botao_importar
			// 
			this.botao_importar.Location = new System.Drawing.Point(220, 147);
			this.botao_importar.Name = "botao_importar";
			this.botao_importar.Size = new System.Drawing.Size(97, 23);
			this.botao_importar.TabIndex = 12;
			this.botao_importar.Text = "Importar";
			this.botao_importar.UseVisualStyleBackColor = true;
			this.botao_importar.Click += new System.EventHandler(this.Button1Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// botao_limpar
			// 
			this.botao_limpar.Location = new System.Drawing.Point(115, 192);
			this.botao_limpar.Name = "botao_limpar";
			this.botao_limpar.Size = new System.Drawing.Size(75, 23);
			this.botao_limpar.TabIndex = 16;
			this.botao_limpar.Text = "Limpar";
			this.botao_limpar.UseVisualStyleBackColor = true;
			this.botao_limpar.Click += new System.EventHandler(this.Button3Click);
			// 
			// botao_deletar
			// 
			this.botao_deletar.Location = new System.Drawing.Point(216, 192);
			this.botao_deletar.Name = "botao_deletar";
			this.botao_deletar.Size = new System.Drawing.Size(75, 23);
			this.botao_deletar.TabIndex = 15;
			this.botao_deletar.Text = "Deletar";
			this.botao_deletar.UseVisualStyleBackColor = true;
			this.botao_deletar.Click += new System.EventHandler(this.Button2Click);
			// 
			// botao_salvar
			// 
			this.botao_salvar.Location = new System.Drawing.Point(23, 192);
			this.botao_salvar.Name = "botao_salvar";
			this.botao_salvar.Size = new System.Drawing.Size(75, 23);
			this.botao_salvar.TabIndex = 14;
			this.botao_salvar.Text = "Salvar";
			this.botao_salvar.UseVisualStyleBackColor = true;
			this.botao_salvar.Click += new System.EventHandler(this.Button4Click);
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
									this.tipo_veiculo});
			this.dataGridView1.Location = new System.Drawing.Point(12, 221);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(580, 243);
			this.dataGridView1.TabIndex = 17;
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
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(445, 116);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(147, 99);
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// campo_tipo_veiculo
			// 
			this.campo_tipo_veiculo.FormattingEnabled = true;
			this.campo_tipo_veiculo.Items.AddRange(new object[] {
									"Automovel",
									"Motocicleta"});
			this.campo_tipo_veiculo.Location = new System.Drawing.Point(115, 12);
			this.campo_tipo_veiculo.Name = "campo_tipo_veiculo";
			this.campo_tipo_veiculo.Size = new System.Drawing.Size(291, 21);
			this.campo_tipo_veiculo.TabIndex = 19;
			this.campo_tipo_veiculo.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// cadastro_placa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 476);
			this.Controls.Add(this.campo_tipo_veiculo);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.botao_limpar);
			this.Controls.Add(this.botao_deletar);
			this.Controls.Add(this.botao_salvar);
			this.Controls.Add(this.botao_importar);
			this.Controls.Add(this.campo_placa);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.campo_proprietario);
			this.Controls.Add(this.campo_cor);
			this.Controls.Add(this.campo_ano);
			this.Controls.Add(this.campo_modelo);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "cadastro_placa";
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
			this.Text = "cadastro_placa";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Cadastro_placaLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ComboBox campo_tipo_veiculo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn tipo_veiculo;
		private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
		private System.Windows.Forms.DataGridViewTextBoxColumn cor;
		private System.Windows.Forms.DataGridViewTextBoxColumn proprietario;
		private System.Windows.Forms.DataGridViewTextBoxColumn placa;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button botao_salvar;
		private System.Windows.Forms.Button botao_deletar;
		private System.Windows.Forms.Button botao_limpar;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button botao_importar;
		private System.Windows.Forms.TextBox campo_placa;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox campo_proprietario;
		private System.Windows.Forms.TextBox campo_cor;
		private System.Windows.Forms.TextBox campo_ano;
		private System.Windows.Forms.TextBox campo_modelo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
