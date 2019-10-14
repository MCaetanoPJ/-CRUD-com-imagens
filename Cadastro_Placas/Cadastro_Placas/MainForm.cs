using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Cadastro_Placas
{
	public partial class Tela_Inicial : Form
	{
		public Tela_Inicial()
		{
			InitializeComponent();
		}
		
		
		void MainFormLoad(object sender, EventArgs e)
		{
			//Inicia o programa em tela cheia
			this.WindowState=FormWindowState.Maximized;
		}
		
		void VeiculoToolStripMenuItemClick(object sender, EventArgs e)//botao que chama o form de cadastro de veiculos
		{
			//Chama a tela de cadastro do veiculo
			cadastro_placa tela_cadastro_placa = new cadastro_placa();
			tela_cadastro_placa.Show();
		}
		
		void PesquisarToolStripMenuItemClick(object sender, EventArgs e)//botao pesquisar
		{
			pesquisa tela_pesquisa = new pesquisa();
			tela_pesquisa.Show();
		}
		
		void PessoaToolStripMenuItemClick(object sender, EventArgs e)//botao que chama o form de cadastro de pessoas
		{
			cadastro_pessoa tela_cadastro_pessoa=new cadastro_pessoa();
			tela_cadastro_pessoa.Show();
		}
		
		void CadastroToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
	}
}
