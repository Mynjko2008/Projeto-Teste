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
    public partial class Frm_ClubesdeFutebol : Form
    {
        int idade;
        int total, Infantil, Juvenil, Junior, Profissional;

        public Frm_ClubesdeFutebol()
        {
            InitializeComponent();
        }

        private void Btn_X1_Click(object sender, EventArgs e)
        {
            Frm_Abertura abertura = new Frm_Abertura();
            abertura.Show();
            Hide();
        }

        private void Frm_ClubesdeFutebol_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação das teclas 
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite Somente Letras", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 8)
            {
                Txt_Idade.Clear();
                Txt_Nome.Clear();
                Txt_Nome.Focus(); //posição do cursor
            }
            if (e.KeyChar == 13)
            {
                if (Txt_Nome.Text != "")
                {
                    Txt_Nome.Enabled = false;
                    Txt_Idade.Enabled = true;
                    Txt_Idade.Focus();

                }
                else
                {
                    MessageBox.Show("Digite o Seu Nome!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); //Mensagem de erro
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
                Txt_Nome.Clear();
                Txt_Nome.Focus(); //posição do cursor
            }
            if (e.KeyChar == 13)
            {
                if (Txt_Idade.Text != "")
                {
                     idade = int.Parse(Txt_Idade.Text);

                   

                    if (idade >= 5 && idade <= 10)
                    {
                        MessageBox.Show(" Parabéns" + " " + Txt_Nome.Text + ", você está dentro da Categoria Infantil!!!", "Sua Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Infantil++;
                        Lbl_Infantil2.Text = Infantil.ToString();
                    }
                    else if (idade >= 11 && idade <= 15)
                    {
                        MessageBox.Show(" Parabéns" + " " + Txt_Nome.Text + ", você está dentro da Categoria Juvenil!!!", "Sua Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Juvenil++;
                        Lbl_Juvenil2.Text = Juvenil.ToString();
                    }
                    else if (idade >= 16 && idade <= 20)
                    {
                        MessageBox.Show(" Parabéns" + " " + Txt_Nome.Text + ", você está dentro da Categoria Junior!!!", "Sua Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Junior++;
                        Lbl_Junior2.Text = Junior.ToString();
                    }
                    else if (idade >= 21 && idade <=25)
                    {
                        MessageBox.Show(" Parabéns" + " " + Txt_Nome.Text + ", você está dentro da Categoria Profissional!!!", "Sua Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Profissional++;
                        Lbl_Profissional2.Text = Profissional.ToString();
                    }
                    else
                    {
                        MessageBox.Show(Txt_Nome.Text + ",Você Não Está Dentro de Nenhuma Categoria!!!", "Você Não Esta Em Nehuma Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    Txt_Idade.Clear();
                    Txt_Nome.Clear();
                    Txt_Idade.Enabled = false;
                    Txt_Nome.Enabled = true;
                    Txt_Nome.Focus(); //posição do cursor
                    total++;
                    Lbl_Total2.Text = total.ToString();

                }
                else
                {
                    MessageBox.Show("Digite Sua Idade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
