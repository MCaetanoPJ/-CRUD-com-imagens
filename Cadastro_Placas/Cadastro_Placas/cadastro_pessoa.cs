using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cadastro_Placas
{

	public partial class cadastro_pessoa : Form
	{
		public cadastro_pessoa()
		{

			InitializeComponent();
			
		}
		
		void TextBox1TextChanged(object sender, EventArgs e) //campo de texto para inserir o nome
		{
		
				
		}
		
		void Button1Click(object sender, EventArgs e)//botao salvar os dados
		{
			//comando de verificação de todos os textbox em busca de algum em branco
			
			//primeiro verificar se o campo nome esta vazio
			if(campo_nome.Text==string.Empty)
			{
				MessageBox.Show("campo nome vazio");
			}
			//verificar se o campo CPF esta vazio
			else if (campo_cpf.Text==string.Empty)
			{
				MessageBox.Show("campo CPF vazio");
			}
			//verificar se o campo RG esta vazio
			else if (campo_rg.Text==string.Empty)
			{
				MessageBox.Show("campo RG vazio");
			}
			//verificar se o campo placa esta vazio
			else if (campo_placa.Text==string.Empty)
			{
				MessageBox.Show("campo placa vazio");
			}
		}
		
		void TextBox2TextChanged(object sender, EventArgs e) //campo de texto para inserir o CPF
		{
			
		}
		
		void TextBox4TextChanged(object sender, EventArgs e)//campo de texto para inserir o RG
		{
						
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)// campo de texto para inserir a placa do carro
		{
			
		}
		
		void Button3Click(object sender, EventArgs e)//botao limpar "deve apagar todos os campos"
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)//botao deletar
		{
			
		}
		
		void Button4Click(object sender, EventArgs e)//botao pesquisar
		{
			
		}
		
		void Cadastro_pessoaLoad(object sender, EventArgs e)//todo o form
		{
			
		}
	}
}
