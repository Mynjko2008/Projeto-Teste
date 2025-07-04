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
    public partial class Frm_contratacao : Form
    {
        string nome, bairro;

        decimal anos;

        int idade;
        int Total, Contratados, Nao_Contratados;


        public Frm_contratacao()
        {
            InitializeComponent();
        }

        private void Btn_X1_Click(object sender, EventArgs e)
        {
            Frm_Abertura abertura = new Frm_Abertura();
            abertura.Show();
            Hide();
        }

        private void Frm_contratacao_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Txt_Candidato_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação das teclas 
            if (!Char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite Somente Letras", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 8)
            {
                Txt_Candidato.Clear();
                Txt_Candidato.Focus(); //posição do cursor
            }
            if (e.KeyChar == 13)
            {
                nome = Txt_Candidato.Text;

                if (Txt_Candidato.Text != "")
                {
                    Txt_Candidato.Enabled = false;
                    Txt_Idade.Enabled = true;
                    Txt_Idade.Focus();
                }
                else
                {
                    MessageBox.Show("Informe O Seu Nome!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cmb_Bairro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Bairro.Enabled == true)
            {
                bairro = Cmb_Bairro.Text;

                Chk_Experiencia.Enabled = true;
                Btn_Confirmar.Enabled = true;
                Btn_Confirmar.BackColor = Color.LightBlue;

            }
            else
            {
                Num_Tempo.Value = 0;
            }
        }

        private void Chk_Experiencia_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_Experiencia.Checked == true)
            {
                Num_Tempo.Enabled = true;
            }
            else
            {
                Num_Tempo.Value = 0;
                Num_Tempo.Enabled = false;

            }
           
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            anos = Num_Tempo.Value;

            if (anos >= 1 && bairro == "Itaquera" || bairro == "Guaianazes" || bairro == "São Matheus" || bairro == "Carrão")
            {
                MessageBox.Show("Parabéns," + nome + " " + "você está contratado (a)!!!", "Parabéns ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Contratados++;
                Lbl_Contratados2.Text = Contratados.ToString();
            }
            else
            {
                MessageBox.Show(nome + "," + "você não está contratado (a)!!!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Nao_Contratados++;
                Lbl_NaoContratados2.Text = Nao_Contratados.ToString();
            }
            Txt_Idade.Text = "";
            Txt_Candidato.Text = "";
            Chk_Experiencia.Checked = false;
            Cmb_Bairro.SelectedIndex = -1;
            Num_Tempo.Value = 0;
            Cmb_Bairro.Enabled = false;
            Chk_Experiencia.Enabled = false;
            Num_Tempo.Enabled = false;
            Txt_Candidato.Enabled = true;
            Txt_Idade.Enabled = false;
            Btn_Confirmar.Enabled = false; 
            Txt_Candidato.Focus();

            Total++;
            Lbl_Total2.Text = Total.ToString();
        }

        private void Cmb_Bairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                
            }
            if (e.KeyChar == 13)
            {


                if (Cmb_Bairro.Text != "")
                {







                }
                else
                {
                    MessageBox.Show("Cade o Bairro?", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Txt_Idade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação das teclas 
            if (!Char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite Somente Número", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 8)
            {
                Txt_Idade.Clear();
                Txt_Candidato.Focus(); //posição do cursor
            }

            if (e.KeyChar == 13)
            {
                idade = int.Parse(Txt_Idade.Text);

                if (idade >= 18 && idade <= 50)
                {
                    Txt_Idade.Enabled = false;
                    Cmb_Bairro.Enabled = true;
                    Cmb_Bairro.Focus();
                }
                else
                {
                    Txt_Idade.Clear();
                    Txt_Idade.Focus();
                    MessageBox.Show("O Candidato deve ser maior de idade até 50 anos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
