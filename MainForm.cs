/* 
* por: Gustavo Augusto Hennig - gustavohe em gmail.com
* novembro de 2007
*/
/*
 * Criado em SharpDevelop.
 * Usuário: 
 * Data: 1/11/2007
 * Hora: 23:05
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PartCnj
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

            SaveData.CarregaMatriz();

		}

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "Processando, aguarde...";
            label5.Refresh();
            CarregaValores();
            AlgoritmoGenetico a = new AlgoritmoGenetico();
            a.EfetuaProcessamento();
            ImprimeResultado(a.MelhorResultado);
//            this.Text = Convert.ToString(a.MelhorResultado.Resultado);
        }

        private void btnSimAne_Click(object sender, EventArgs e)
        {
            label5.Text = "Processando, aguarde...";
            label5.Refresh();
            CarregaValores();
            SimulatedAnnealing s = new SimulatedAnnealing();
            s.Process();

            ImprimeResultado(s.MelhorResultado);
            //this
        }

        private void CarregaValores()
        {

            try{
                Global.MaxGrupos = Convert.ToInt32(txtMaxGrupos.Text);
                Global.MinGrupos = Convert.ToInt32(txtMinGrupos.Text);
                Global.TamPopulacao = Convert.ToInt32(txtPopulacao.Text);
                Global.NroIteracoes = Convert.ToInt32(txtIteracoes.Text);
                
            }catch(Exception e){
                MessageBox.Show(e.Message);
            }
            

        }

        private void ImprimeResultado(Estado e)
        {
            label5.Text = "                      1, 2, 3, 4, 5, 6, 7, 8, 9, 10\n"; 
            label5.Text += "Resultado encontrado: "+ e.ToString();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveData.GravaMatriz();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Para alterar a matriz é necessário modificar o arquivo Matriz.cs, ou o saveddata.xml(Mais complicado)\n\n"+
                "Não foi feito um editor para a matriz devido ao curto prazo\n\n" +
                "Lembre-se de apagar o arquivo saveddata.xml se o arquivo Matriz.cs for alterado.");

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
