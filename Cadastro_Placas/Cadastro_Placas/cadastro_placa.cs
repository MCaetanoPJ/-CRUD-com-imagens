using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cadastro_Placas
{
	public partial class cadastro_placa : Form
	{
		public cadastro_placa()
		{
			InitializeComponent();
		}
		
		void Cadastro_placaLoad(object sender, EventArgs e)//form inteiro
		{
			
		}
		
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)//Select que mostra o tipo de veiculo
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)//botao importar imagem da placa para um diretorio pre-definido
		{
			//openfiledialog: comando para abrir tela de pesquisa
			//tela_pesquisa: variavel atribuida ao form a ser aberto
			//new openfiledialog: atribui o comando openfiledialog a variavel tela_pesquisa
			//tela_pesquisa.showdialog:comando para exibir na tela a janela de pesquisa do windows
			OpenFileDialog tela_pesquisa = new OpenFileDialog();
			tela_pesquisa.ShowDialog();
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)//campo de texto para o modelo do veiculo
		{
			
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)//campo de texto para salvar o ano do veiculo
		{
			
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)//campo de texto para salvar a cor do veiculo
		{
			
		}
		
		void TextBox4TextChanged(object sender, EventArgs e)//campo de texto para salvar o nome do proprietario do veiculo
		{
			
		}
		
		void Button4Click(object sender, EventArgs e)//botao salvar
		{
			//comando de verificação de alguns textbox em busca de algum em branco
			
			//verificar se o campo tipo de veiculo esta vazio
			if(campo_tipo_veiculo.Text==string.Empty)
			{
				MessageBox.Show("Tipo de veiculo não especificado");
			}
			//verificar se o campo modelo esta vazio
			else if(campo_modelo.Text==string.Empty)
			{
				MessageBox.Show("Modelo do veiculo não especificado");
			}
			//verificar se o campo ano esta vazio
			else if(campo_ano.Text==string.Empty)
			{
				MessageBox.Show("ano do veiculo não especificado");
			}
			//verificar se o campo cor esta vazio
			else if(campo_cor.Text==string.Empty)
			{
				MessageBox.Show("cor do veiculo não especificado");
			}
			//verificar se o campo proprietario esta vazio
			else if(campo_proprietario.Text==string.Empty)
			{
				MessageBox.Show("Proprietario do veiculo não informado");
			}
			//verificar se o campo placa esta vazio
			else if(campo_placa.Text==string.Empty)
			{
				MessageBox.Show("imagem da placa do veiculo não importada ou não escrita");
			}				
		}
		
		void Button3Click(object sender, EventArgs e)//botao limpar
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)//boptao deletar
		{
			
		}
		
		void PictureBox1Click(object sender, EventArgs e)//panel criado para mostrar em miniatura a placa apos ser importada
		{
			
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)//Grid que mostra informações sobre o carro extraidas do banco de dados
		{
			
		}
	}
}
