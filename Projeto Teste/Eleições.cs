using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Teste
{
    public partial class Frm_Eleições : Form
    {
        int idade;
        int Voto_Obrigatório, Voto_Facultativo, Total;

        public Frm_Eleições()
        {
            InitializeComponent();
        }

        private void Eleições_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_X1_Click(object sender, EventArgs e)
        {
            Frm_Abertura abertura = new Frm_Abertura();
            abertura.Show();
            Hide();
        }

        private void Txt_idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação das teclas 
            if (!Char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite Somente Número", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 8)
            {
                Txt_idade.Clear();
                Txt_idade.Focus(); //posição do cursor
            }
            if (e.KeyChar == 13)
            {
                if (Txt_idade.Text != "")
                {
                    idade = int.Parse(Txt_idade.Text);

                    if (idade <= 15)
                    {
                        MessageBox.Show(" Você Não Tem Idade Para Votar!!! ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else if (idade >= 18 && idade <= 70)
                    {
                        MessageBox.Show(" Voto Obrigatório!!! ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Voto_Obrigatório++;
                        Lbl_Obrigatorio2.Text = Voto_Obrigatório.ToString();
                    }
                    else
                    {
                        MessageBox.Show(" O Voto é Facultativo!!! ", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Voto_Facultativo++;
                        Lbl_Faultativo2.Text = Voto_Facultativo.ToString();
                    }
                    Txt_idade.Clear();
                    Txt_idade.Focus(); //posição do cursor
                    Total++;
                    Lbl_Total2.Text = Total.ToString();

                }
                else
                {
                    MessageBox.Show("Digite Sua Idade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_idade.Focus(); //posição do cursor
                }
            }
        }

        private void Frm_Eleições_Load(object sender, EventArgs e)
        {

        }
    }
}
