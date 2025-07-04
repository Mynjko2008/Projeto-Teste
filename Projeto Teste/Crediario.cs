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
    public partial class Frm_Crediario : Form
    {
        int renda, valor;
        string nome;
        int cashback = 10, cont_atendidos, cont_bloqueados, cont_liberados;

        public Frm_Crediario()
        {
            InitializeComponent();
        }

        private void Btn_X1_Click(object sender, EventArgs e)
        {
            Frm_Abertura abertura = new Frm_Abertura();
            abertura.Show();
            Hide();
        }

        private void Frm_Crediario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void Txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação das teclas 
            if (!Char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite Somente Letras", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(e.KeyChar == 8)
            {
                Txt_Nome.Clear();
                Txt_Nome.Focus(); //posição do cursor
            }
            if (e.KeyChar == 13)
            {
                nome = Txt_Nome.Text;

                if (Txt_Nome.Text != "")
                {
                    Txt_Nome.Enabled = false;
                    Txt_Renda.Enabled = true;
                    Txt_Valor.Enabled = false;
                    Txt_Renda.Focus();
                }
                else
                {
                    MessageBox.Show("Digite O Seu Nome Para Continuar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void Txt_Renda_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação das teclas 
            if (!Char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite Somente Número", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 8)
            {
                Txt_Renda.Clear();
                Txt_Nome.Focus(); //posição do cursor
            }

            if (e.KeyChar == 13)
            {
                if (Txt_Renda.Text != "")
                {
                    renda = int.Parse(Txt_Renda.Text);

                    
                    //Formatação Em Reais
                    Txt_Renda.Text = renda.ToString("c2");

                    MessageBox.Show("Você Tem R$" + renda, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Txt_Valor.Enabled = true;
                    Txt_Renda.Enabled = false;
                    Txt_Valor.Focus();
                }
                else
                {
                    MessageBox.Show("Digite Sua Renda", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            Txt_Renda.Clear();
            Txt_Valor.Clear();
            Txt_Renda.Enabled = false;
            Txt_Valor.Enabled = false;
            Txt_Nome.Enabled = true;
            Txt_Nome.Focus();
        }

        private void Txt_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação das teclas 
            if (!Char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite Somente Número", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 8)
            {
                Txt_Valor.Clear();
                Txt_Nome.Focus(); //posição do cursor
            }
            if (e.KeyChar == 13)
            {
                

                if (Txt_Valor.Text != "")
                {
                    valor = int.Parse(Txt_Valor.Text);

                    //Formatação Em Reais
                    Txt_Valor.Text = valor.ToString("c2");

                    if (renda >= valor)
                    {
                        MessageBox.Show("Parabens," + nome + " " + "Você Está Liberado Para A Sua Compra", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cont_liberados++; //contando de 1 em 1 cada pessoa Liberada
                        Lbl_Liberados2.Text = cont_liberados.ToString();//resebendo a contagen dos liberados

                        if (cashback == 0) //Condição para verificar se o cashbak acabou
                        {
                            Lbl_CashBack2.Text = " ** Esgotado **"; //Munando quando zerar dizer "esgotado"
                        }
                        else //caso contrario, se não zera o cashback vai diminuindo de um em um
                        {
                            cashback--; //diminuindo de 1 em 1
                            Lbl_CashBack2.Text = cashback.ToString();
                        }
                    }
                    else if (renda < valor)
                    {
                        MessageBox.Show(nome + " " + "Você Está Bloqueado Para A Sua Compra", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cont_bloqueados++; //contando de 1 em 1 cada pessoa bloqueada
                        Lbl_Bloqueado2.Text = cont_bloqueados.ToString();//resebendo a contagen dos bloqueados
                    }
                    cont_atendidos++;
                    Lbl_Atendidos2.Text = cont_atendidos.ToString();
                    Txt_Nome.Clear();
                    Txt_Renda.Clear();
                    Txt_Valor.Clear();
                    Txt_Valor.Enabled = false;
                    Txt_Renda.Enabled = false;
                    Txt_Nome.Enabled = true;
                    Txt_Nome.Focus(); //posição do cursor
                    
                }
                else
                {
                        MessageBox.Show("Digite o Valor Da Compra", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Txt_Valor.Focus();
                }
            }
        }
    }
}
