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
    public partial class Frm_Peixe : Form
    {
        public Frm_Peixe()
        {
            InitializeComponent();
        }

        

        private void Frm_Peixe_Load(object sender, EventArgs e)
        {
            Wmp_Peixe.URL = "Peixe Girando.mp4";
        }

        private void Frm_Peixe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                if (MessageBox.Show("Deseja sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

       

        private void Btn_Pular_Click(object sender, EventArgs e)
        {
            Frm_Abertura abertura = new Frm_Abertura();
            abertura.Show();
            Hide();
        }

        private void Timer_Pular_Tick(object sender, EventArgs e)
        {
            Timer_Peixe.Start();
            Btn_Pular.Visible = true;
            Timer_Peixe.Stop();
        }

        private void Timer_Peixe_Tick(object sender, EventArgs e)
        {
            Timer_Peixe.Start();
            Btn_Pular.Visible = true;
            Timer_Peixe.Stop();
        }
    }
}
