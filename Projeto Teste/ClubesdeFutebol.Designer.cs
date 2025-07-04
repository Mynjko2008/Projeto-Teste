
namespace Projeto_Teste
{
    partial class Frm_ClubesdeFutebol
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
            this.Lbl_Clubes = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_Idade = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_Idade = new System.Windows.Forms.TextBox();
            this.Lbl_Total1 = new System.Windows.Forms.Label();
            this.Lbl_Infantil1 = new System.Windows.Forms.Label();
            this.Lbl_Juvenil1 = new System.Windows.Forms.Label();
            this.Lbl_Junior1 = new System.Windows.Forms.Label();
            this.Lbl_Profissional1 = new System.Windows.Forms.Label();
            this.Lbl_Total2 = new System.Windows.Forms.Label();
            this.Lbl_Infantil2 = new System.Windows.Forms.Label();
            this.Lbl_Juvenil2 = new System.Windows.Forms.Label();
            this.Lbl_Junior2 = new System.Windows.Forms.Label();
            this.Lbl_Profissional2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_X1
            // 
            this.Btn_X1.BackColor = System.Drawing.Color.Red;
            this.Btn_X1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_X1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_X1.ForeColor = System.Drawing.Color.White;
            this.Btn_X1.Location = new System.Drawing.Point(969, 12);
            this.Btn_X1.Name = "Btn_X1";
            this.Btn_X1.Size = new System.Drawing.Size(53, 43);
            this.Btn_X1.TabIndex = 1;
            this.Btn_X1.Text = "X";
            this.Btn_X1.UseVisualStyleBackColor = false;
            this.Btn_X1.Click += new System.EventHandler(this.Btn_X1_Click);
            // 
            // Lbl_Clubes
            // 
            this.Lbl_Clubes.AutoSize = true;
            this.Lbl_Clubes.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Clubes.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Clubes.ForeColor = System.Drawing.Color.White;
            this.Lbl_Clubes.Location = new System.Drawing.Point(400, 9);
            this.Lbl_Clubes.Name = "Lbl_Clubes";
            this.Lbl_Clubes.Size = new System.Drawing.Size(310, 38);
            this.Lbl_Clubes.TabIndex = 2;
            this.Lbl_Clubes.Text = "Clubes De Futebol";
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Nome.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.ForeColor = System.Drawing.Color.White;
            this.Lbl_Nome.Location = new System.Drawing.Point(276, 100);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(100, 34);
            this.Lbl_Nome.TabIndex = 3;
            this.Lbl_Nome.Text = "Nome:";
            // 
            // Lbl_Idade
            // 
            this.Lbl_Idade.AutoSize = true;
            this.Lbl_Idade.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Idade.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Idade.ForeColor = System.Drawing.Color.White;
            this.Lbl_Idade.Location = new System.Drawing.Point(276, 261);
            this.Lbl_Idade.Name = "Lbl_Idade";
            this.Lbl_Idade.Size = new System.Drawing.Size(101, 34);
            this.Lbl_Idade.TabIndex = 4;
            this.Lbl_Idade.Text = "Idade:";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Location = new System.Drawing.Point(382, 114);
            this.Txt_Nome.MaxLength = 50;
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(306, 20);
            this.Txt_Nome.TabIndex = 1;
            this.Txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nome_KeyPress);
            // 
            // Txt_Idade
            // 
            this.Txt_Idade.Enabled = false;
            this.Txt_Idade.Location = new System.Drawing.Point(382, 274);
            this.Txt_Idade.MaxLength = 2;
            this.Txt_Idade.Name = "Txt_Idade";
            this.Txt_Idade.Size = new System.Drawing.Size(100, 20);
            this.Txt_Idade.TabIndex = 9;
            this.Txt_Idade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Idade_KeyPress);
            // 
            // Lbl_Total1
            // 
            this.Lbl_Total1.AutoSize = true;
            this.Lbl_Total1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Total1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total1.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_Total1.Location = new System.Drawing.Point(56, 366);
            this.Lbl_Total1.Name = "Lbl_Total1";
            this.Lbl_Total1.Size = new System.Drawing.Size(180, 24);
            this.Lbl_Total1.TabIndex = 10;
            this.Lbl_Total1.Text = "Total De Inscritos";
            // 
            // Lbl_Infantil1
            // 
            this.Lbl_Infantil1.AutoSize = true;
            this.Lbl_Infantil1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Infantil1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Infantil1.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_Infantil1.Location = new System.Drawing.Point(252, 366);
            this.Lbl_Infantil1.Name = "Lbl_Infantil1";
            this.Lbl_Infantil1.Size = new System.Drawing.Size(86, 24);
            this.Lbl_Infantil1.TabIndex = 11;
            this.Lbl_Infantil1.Text = "Infantil";
            // 
            // Lbl_Juvenil1
            // 
            this.Lbl_Juvenil1.AutoSize = true;
            this.Lbl_Juvenil1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Juvenil1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Juvenil1.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_Juvenil1.Location = new System.Drawing.Point(352, 366);
            this.Lbl_Juvenil1.Name = "Lbl_Juvenil1";
            this.Lbl_Juvenil1.Size = new System.Drawing.Size(80, 24);
            this.Lbl_Juvenil1.TabIndex = 12;
            this.Lbl_Juvenil1.Text = "Juvenil";
            // 
            // Lbl_Junior1
            // 
            this.Lbl_Junior1.AutoSize = true;
            this.Lbl_Junior1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Junior1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Junior1.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_Junior1.Location = new System.Drawing.Point(442, 366);
            this.Lbl_Junior1.Name = "Lbl_Junior1";
            this.Lbl_Junior1.Size = new System.Drawing.Size(72, 24);
            this.Lbl_Junior1.TabIndex = 13;
            this.Lbl_Junior1.Text = "Junior";
            // 
            // Lbl_Profissional1
            // 
            this.Lbl_Profissional1.AutoSize = true;
            this.Lbl_Profissional1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Profissional1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Profissional1.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_Profissional1.Location = new System.Drawing.Point(520, 366);
            this.Lbl_Profissional1.Name = "Lbl_Profissional1";
            this.Lbl_Profissional1.Size = new System.Drawing.Size(125, 24);
            this.Lbl_Profissional1.TabIndex = 14;
            this.Lbl_Profissional1.Text = "Profissional";
            // 
            // Lbl_Total2
            // 
            this.Lbl_Total2.AutoSize = true;
            this.Lbl_Total2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Total2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total2.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_Total2.Location = new System.Drawing.Point(113, 430);
            this.Lbl_Total2.Name = "Lbl_Total2";
            this.Lbl_Total2.Size = new System.Drawing.Size(21, 24);
            this.Lbl_Total2.TabIndex = 15;
            this.Lbl_Total2.Text = "0";
            // 
            // Lbl_Infantil2
            // 
            this.Lbl_Infantil2.AutoSize = true;
            this.Lbl_Infantil2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Infantil2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Infantil2.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_Infantil2.Location = new System.Drawing.Point(278, 430);
            this.Lbl_Infantil2.Name = "Lbl_Infantil2";
            this.Lbl_Infantil2.Size = new System.Drawing.Size(21, 24);
            this.Lbl_Infantil2.TabIndex = 16;
            this.Lbl_Infantil2.Text = "0";
            // 
            // Lbl_Juvenil2
            // 
            this.Lbl_Juvenil2.AutoSize = true;
            this.Lbl_Juvenil2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Juvenil2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Juvenil2.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_Juvenil2.Location = new System.Drawing.Point(378, 430);
            this.Lbl_Juvenil2.Name = "Lbl_Juvenil2";
            this.Lbl_Juvenil2.Size = new System.Drawing.Size(21, 24);
            this.Lbl_Juvenil2.TabIndex = 17;
            this.Lbl_Juvenil2.Text = "0";
            // 
            // Lbl_Junior2
            // 
            this.Lbl_Junior2.AutoSize = true;
            this.Lbl_Junior2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Junior2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Junior2.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_Junior2.Location = new System.Drawing.Point(461, 430);
            this.Lbl_Junior2.Name = "Lbl_Junior2";
            this.Lbl_Junior2.Size = new System.Drawing.Size(21, 24);
            this.Lbl_Junior2.TabIndex = 18;
            this.Lbl_Junior2.Text = "0";
            // 
            // Lbl_Profissional2
            // 
            this.Lbl_Profissional2.AutoSize = true;
            this.Lbl_Profissional2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Profissional2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Profissional2.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_Profissional2.Location = new System.Drawing.Point(565, 430);
            this.Lbl_Profissional2.Name = "Lbl_Profissional2";
            this.Lbl_Profissional2.Size = new System.Drawing.Size(21, 24);
            this.Lbl_Profissional2.TabIndex = 19;
            this.Lbl_Profissional2.Text = "0";
            // 
            // Frm_ClubesdeFutebol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Teste.Properties.Resources.Escanteio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1034, 639);
            this.Controls.Add(this.Lbl_Profissional2);
            this.Controls.Add(this.Lbl_Junior2);
            this.Controls.Add(this.Lbl_Juvenil2);
            this.Controls.Add(this.Lbl_Infantil2);
            this.Controls.Add(this.Lbl_Total2);
            this.Controls.Add(this.Lbl_Profissional1);
            this.Controls.Add(this.Lbl_Junior1);
            this.Controls.Add(this.Lbl_Juvenil1);
            this.Controls.Add(this.Lbl_Infantil1);
            this.Controls.Add(this.Lbl_Total1);
            this.Controls.Add(this.Txt_Idade);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Lbl_Idade);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Lbl_Clubes);
            this.Controls.Add(this.Btn_X1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ClubesdeFutebol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClubesdeFutebol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_ClubesdeFutebol_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_X1;
        private System.Windows.Forms.Label Lbl_Clubes;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_Idade;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.TextBox Txt_Idade;
        private System.Windows.Forms.Label Lbl_Total1;
        private System.Windows.Forms.Label Lbl_Infantil1;
        private System.Windows.Forms.Label Lbl_Juvenil1;
        private System.Windows.Forms.Label Lbl_Junior1;
        private System.Windows.Forms.Label Lbl_Profissional1;
        private System.Windows.Forms.Label Lbl_Total2;
        private System.Windows.Forms.Label Lbl_Infantil2;
        private System.Windows.Forms.Label Lbl_Juvenil2;
        private System.Windows.Forms.Label Lbl_Junior2;
        private System.Windows.Forms.Label Lbl_Profissional2;
    }
}