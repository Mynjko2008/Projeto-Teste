
namespace Projeto_Teste
{
    partial class Frm_Crediario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_X1 = new System.Windows.Forms.Button();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_SuaRenda = new System.Windows.Forms.Label();
            this.Lbl_Valor = new System.Windows.Forms.Label();
            this.Txt_Valor = new System.Windows.Forms.TextBox();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_Renda = new System.Windows.Forms.TextBox();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Lbl_CashBack1 = new System.Windows.Forms.Label();
            this.Lbl_Atendidos1 = new System.Windows.Forms.Label();
            this.Lbl_Liberados2 = new System.Windows.Forms.Label();
            this.Lbl_Bloqueados1 = new System.Windows.Forms.Label();
            this.Lbl_Bloqueado2 = new System.Windows.Forms.Label();
            this.Lbl_Liberados1 = new System.Windows.Forms.Label();
            this.Lbl_Atendidos2 = new System.Windows.Forms.Label();
            this.Lbl_CashBack2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_X1
            // 
            this.Btn_X1.BackColor = System.Drawing.Color.Red;
            this.Btn_X1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_X1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_X1.ForeColor = System.Drawing.Color.White;
            this.Btn_X1.Location = new System.Drawing.Point(1052, 12);
            this.Btn_X1.Name = "Btn_X1";
            this.Btn_X1.Size = new System.Drawing.Size(53, 43);
            this.Btn_X1.TabIndex = 5;
            this.Btn_X1.Text = "X";
            this.Btn_X1.UseVisualStyleBackColor = false;
            this.Btn_X1.Click += new System.EventHandler(this.Btn_X1_Click);
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Nome.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Nome.Location = new System.Drawing.Point(341, 119);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(68, 24);
            this.Lbl_Nome.TabIndex = 6;
            this.Lbl_Nome.Text = "Nome:";
            // 
            // Lbl_SuaRenda
            // 
            this.Lbl_SuaRenda.AutoSize = true;
            this.Lbl_SuaRenda.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_SuaRenda.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SuaRenda.Location = new System.Drawing.Point(292, 178);
            this.Lbl_SuaRenda.Name = "Lbl_SuaRenda";
            this.Lbl_SuaRenda.Size = new System.Drawing.Size(117, 24);
            this.Lbl_SuaRenda.TabIndex = 7;
            this.Lbl_SuaRenda.Text = "Sua Renda:";
            // 
            // Lbl_Valor
            // 
            this.Lbl_Valor.AutoSize = true;
            this.Lbl_Valor.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Valor.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Valor.Location = new System.Drawing.Point(226, 224);
            this.Lbl_Valor.Name = "Lbl_Valor";
            this.Lbl_Valor.Size = new System.Drawing.Size(183, 24);
            this.Lbl_Valor.TabIndex = 8;
            this.Lbl_Valor.Text = "Valor Do Produto:";
            // 
            // Txt_Valor
            // 
            this.Txt_Valor.Enabled = false;
            this.Txt_Valor.Location = new System.Drawing.Point(415, 229);
            this.Txt_Valor.Name = "Txt_Valor";
            this.Txt_Valor.Size = new System.Drawing.Size(120, 20);
            this.Txt_Valor.TabIndex = 9;
            this.Txt_Valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Valor_KeyPress);
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(415, 119);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(200, 20);
            this.Txt_Nome.TabIndex = 1;
            this.Txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nome_KeyPress);
            // 
            // Txt_Renda
            // 
            this.Txt_Renda.Enabled = false;
            this.Txt_Renda.Location = new System.Drawing.Point(415, 178);
            this.Txt_Renda.Name = "Txt_Renda";
            this.Txt_Renda.Size = new System.Drawing.Size(120, 20);
            this.Txt_Renda.TabIndex = 11;
            this.Txt_Renda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Renda_KeyPress);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.FlatAppearance.BorderSize = 0;
            this.Btn_Editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.Btn_Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Editar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.Location = new System.Drawing.Point(635, 120);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(92, 23);
            this.Btn_Editar.TabIndex = 12;
            this.Btn_Editar.Text = "Editar";
            this.Btn_Editar.UseVisualStyleBackColor = true;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Lbl_CashBack1
            // 
            this.Lbl_CashBack1.AutoSize = true;
            this.Lbl_CashBack1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CashBack1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CashBack1.Location = new System.Drawing.Point(266, 343);
            this.Lbl_CashBack1.Name = "Lbl_CashBack1";
            this.Lbl_CashBack1.Size = new System.Drawing.Size(102, 24);
            this.Lbl_CashBack1.TabIndex = 13;
            this.Lbl_CashBack1.Text = "CashBack";
            // 
            // Lbl_Atendidos1
            // 
            this.Lbl_Atendidos1.AutoSize = true;
            this.Lbl_Atendidos1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Atendidos1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Atendidos1.Location = new System.Drawing.Point(389, 343);
            this.Lbl_Atendidos1.Name = "Lbl_Atendidos1";
            this.Lbl_Atendidos1.Size = new System.Drawing.Size(101, 24);
            this.Lbl_Atendidos1.TabIndex = 14;
            this.Lbl_Atendidos1.Text = "Atendidos";
            // 
            // Lbl_Liberados2
            // 
            this.Lbl_Liberados2.AutoSize = true;
            this.Lbl_Liberados2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Liberados2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Liberados2.Location = new System.Drawing.Point(557, 386);
            this.Lbl_Liberados2.Name = "Lbl_Liberados2";
            this.Lbl_Liberados2.Size = new System.Drawing.Size(21, 24);
            this.Lbl_Liberados2.TabIndex = 15;
            this.Lbl_Liberados2.Text = "0";
            // 
            // Lbl_Bloqueados1
            // 
            this.Lbl_Bloqueados1.AutoSize = true;
            this.Lbl_Bloqueados1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Bloqueados1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bloqueados1.Location = new System.Drawing.Point(634, 343);
            this.Lbl_Bloqueados1.Name = "Lbl_Bloqueados1";
            this.Lbl_Bloqueados1.Size = new System.Drawing.Size(116, 24);
            this.Lbl_Bloqueados1.TabIndex = 16;
            this.Lbl_Bloqueados1.Text = "Bloqueados";
            // 
            // Lbl_Bloqueado2
            // 
            this.Lbl_Bloqueado2.AutoSize = true;
            this.Lbl_Bloqueado2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Bloqueado2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bloqueado2.Location = new System.Drawing.Point(682, 386);
            this.Lbl_Bloqueado2.Name = "Lbl_Bloqueado2";
            this.Lbl_Bloqueado2.Size = new System.Drawing.Size(21, 24);
            this.Lbl_Bloqueado2.TabIndex = 17;
            this.Lbl_Bloqueado2.Text = "0";
            // 
            // Lbl_Liberados1
            // 
            this.Lbl_Liberados1.AutoSize = true;
            this.Lbl_Liberados1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Liberados1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Liberados1.Location = new System.Drawing.Point(511, 343);
            this.Lbl_Liberados1.Name = "Lbl_Liberados1";
            this.Lbl_Liberados1.Size = new System.Drawing.Size(102, 24);
            this.Lbl_Liberados1.TabIndex = 18;
            this.Lbl_Liberados1.Text = "Liberados";
            // 
            // Lbl_Atendidos2
            // 
            this.Lbl_Atendidos2.AutoSize = true;
            this.Lbl_Atendidos2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Atendidos2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Atendidos2.Location = new System.Drawing.Point(437, 386);
            this.Lbl_Atendidos2.Name = "Lbl_Atendidos2";
            this.Lbl_Atendidos2.Size = new System.Drawing.Size(21, 24);
            this.Lbl_Atendidos2.TabIndex = 19;
            this.Lbl_Atendidos2.Text = "0";
            // 
            // Lbl_CashBack2
            // 
            this.Lbl_CashBack2.AutoSize = true;
            this.Lbl_CashBack2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CashBack2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CashBack2.Location = new System.Drawing.Point(266, 386);
            this.Lbl_CashBack2.Name = "Lbl_CashBack2";
            this.Lbl_CashBack2.Size = new System.Drawing.Size(32, 24);
            this.Lbl_CashBack2.TabIndex = 20;
            this.Lbl_CashBack2.Text = "10";
            // 
            // Frm_Crediario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Teste.Properties.Resources.Tela_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1117, 609);
            this.Controls.Add(this.Lbl_CashBack2);
            this.Controls.Add(this.Lbl_Atendidos2);
            this.Controls.Add(this.Lbl_Liberados1);
            this.Controls.Add(this.Lbl_Bloqueado2);
            this.Controls.Add(this.Lbl_Bloqueados1);
            this.Controls.Add(this.Lbl_Liberados2);
            this.Controls.Add(this.Lbl_Atendidos1);
            this.Controls.Add(this.Lbl_CashBack1);
            this.Controls.Add(this.Btn_Editar);
            this.Controls.Add(this.Txt_Renda);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Txt_Valor);
            this.Controls.Add(this.Lbl_Valor);
            this.Controls.Add(this.Lbl_SuaRenda);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Btn_X1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Crediario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crediario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Crediario_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_X1;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_SuaRenda;
        private System.Windows.Forms.Label Lbl_Valor;
        private System.Windows.Forms.TextBox Txt_Valor;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.TextBox Txt_Renda;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Label Lbl_CashBack1;
        private System.Windows.Forms.Label Lbl_Atendidos1;
        private System.Windows.Forms.Label Lbl_Liberados2;
        private System.Windows.Forms.Label Lbl_Bloqueados1;
        private System.Windows.Forms.Label Lbl_Bloqueado2;
        private System.Windows.Forms.Label Lbl_Liberados1;
        private System.Windows.Forms.Label Lbl_Atendidos2;
        private System.Windows.Forms.Label Lbl_CashBack2;
    }
}