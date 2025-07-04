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
    public partial class Frm_Abertura : Form
    {
        public Frm_Abertura()
        {
            InitializeComponent();
        }

        private void Btn_X1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Pic_Meses_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrando Na Tela Selecionada", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Frm_Meses meses = new Frm_Meses();
            meses.Show();
            Hide();
        }

        private void Pic_Clubes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrando Na Tela Selecionada", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Frm_ClubesdeFutebol clubesdeFutebol = new Frm_ClubesdeFutebol();
            clubesdeFutebol.Show();
            Hide();
        }

        private void Pic_Eleições_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrando Na Tela Selecionada", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Frm_Eleições eleições = new Frm_Eleições();
            eleições.Show();
            Hide();
        }

        private void Frm_Abertura_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Pic_Contratacao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrando Na Tela Selecionada", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Frm_contratacao contratacao = new Frm_contratacao();
            contratacao.Show();
            Hide();
        }

        private void Pic_Crediario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Entrando Na Tela Selecionada", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Frm_Crediario crediario = new Frm_Crediario();
            crediario.Show();
            Hide();
        }
    }
}
