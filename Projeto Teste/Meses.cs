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
    public partial class Frm_Meses : Form
    {
        int mes;

        public Frm_Meses()
        {
            InitializeComponent();
        }

        private void Frm_Meses_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Btn_X1_Click(object sender, EventArgs e)
        {
            Frm_Abertura abertura = new Frm_Abertura();
            abertura.Show();
            Hide();

        }

        private void Txt_Digite_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validação das teclas 
            if (!Char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite Somente Número", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (e.KeyChar == 8)
            {
                Controls.Clear(); //Limpar tudo liralmente 
                InitializeComponent(); //inicializar todos os componetes
                Txt_Digite.Focus(); //posição do cursor
            }
            if (e.KeyChar == 13)
            {
                if (Txt_Digite.Text != "")
                {
                    mes = int.Parse(Txt_Digite.Text);
                    if (mes == 1)
                    {
                        Lbl_2024.Text = "Janeiro";
                        Txt_Digite.Clear();

                        Txt_Digite.Focus();
                    }
                    else if (mes == 2)
                    {
                        Lbl_2024.Text = "Fevereiro";
                        Txt_Digite.Clear();

                        Txt_Digite.Focus();
                    }
                    else if (mes == 3)
                    {
                        Lbl_2024.Text = "Março";
                        Txt_Digite.Clear();

                        Txt_Digite.Focus();
                    }
                    else if (mes == 4)
                    {
                        Lbl_2024.Text = "Abril";
                        Txt_Digite.Clear();

                        Txt_Digite.Focus();
                    }
                    else if (mes == 5)
                    {
                        Lbl_2024.Text = "Maio";
                        Txt_Digite.Clear();

                        Txt_Digite.Focus();
                    }
                    else if (mes == 6)
                    {
                        Lbl_2024.Text = "Junho";
                        Txt_Digite.Clear();

                        Txt_Digite.Focus();
                    }
                    else if (mes == 7)
                    {
                        Lbl_2024.Text = "Julho";
                        Txt_Digite.Clear();

                        Txt_Digite.Focus();
                    }
                    else if (mes == 8)
                    {
                        Lbl_2024.Text = "Agosto";
                        Txt_Digite.Clear();

                        Txt_Digite.Focus();
                    }
                    else if (mes == 9)
                    {
                        Lbl_2024.Text = "Setembro";
                        Txt_Digite.Clear();

                        Txt_Digite.Focus();
                    }
                    else if (mes == 10)
                    {
                        Lbl_2024.Text = "Outubro";
                        Txt_Digite.Clear();

                        Txt_Digite.Focus();
                    }
                    else if (mes == 11)
                    {
                        Lbl_2024.Text = "Novembro";
                        Txt_Digite.Clear();

                        Txt_Digite.Focus();
                    }
                    else if (mes == 12)
                    {
                        Lbl_2024.Text = "Dezembro";
                        Txt_Digite.Clear();

                        Txt_Digite.Focus();
                    }
                    else
                    {
                    Txt_Digite.Clear();

                    Txt_Digite.Focus();
                    MessageBox.Show("O Mes Digitado é Invalido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    
                    
                }
                else
                {
                    MessageBox.Show("Digite o Mes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txt_Digite.Focus();
                }
            
            }
        }

    }
}
