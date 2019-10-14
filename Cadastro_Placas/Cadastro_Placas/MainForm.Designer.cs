/*
 * Created by SharpDevelop.
 * User: Marcos
 * Date: 09/03/2018
 * Time: 16:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Cadastro_Placas
{
	partial class Tela_Inicial
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.botao_cadastro_pessoa = new System.Windows.Forms.ToolStripMenuItem();
			this.botao_cadastro_veiculo = new System.Windows.Forms.ToolStripMenuItem();
			this.botao_pesquisar = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cadastroToolStripMenuItem,
									this.botao_pesquisar});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(587, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// cadastroToolStripMenuItem
			// 
			this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.botao_cadastro_pessoa,
									this.botao_cadastro_veiculo});
			this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
			this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.cadastroToolStripMenuItem.Text = "Cadastro";
			this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.CadastroToolStripMenuItemClick);
			// 
			// botao_cadastro_pessoa
			// 
			this.botao_cadastro_pessoa.Name = "botao_cadastro_pessoa";
			this.botao_cadastro_pessoa.Size = new System.Drawing.Size(152, 22);
			this.botao_cadastro_pessoa.Text = "Pessoa";
			this.botao_cadastro_pessoa.Click += new System.EventHandler(this.PessoaToolStripMenuItemClick);
			// 
			// botao_cadastro_veiculo
			// 
			this.botao_cadastro_veiculo.Name = "botao_cadastro_veiculo";
			this.botao_cadastro_veiculo.Size = new System.Drawing.Size(152, 22);
			this.botao_cadastro_veiculo.Text = "Veiculo";
			this.botao_cadastro_veiculo.Click += new System.EventHandler(this.VeiculoToolStripMenuItemClick);
			// 
			// botao_pesquisar
			// 
			this.botao_pesquisar.Name = "botao_pesquisar";
			this.botao_pesquisar.Size = new System.Drawing.Size(69, 20);
			this.botao_pesquisar.Text = "Pesquisar";
			this.botao_pesquisar.Click += new System.EventHandler(this.PesquisarToolStripMenuItemClick);
			// 
			// Tela_Inicial
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(587, 320);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Tela_Inicial";
			this.Text = "Cadastro_Placas";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem botao_cadastro_pessoa;
		private System.Windows.Forms.ToolStripMenuItem botao_pesquisar;
		private System.Windows.Forms.ToolStripMenuItem botao_cadastro_veiculo;
		private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
