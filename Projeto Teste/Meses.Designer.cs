
namespace Projeto_Teste
{
    partial class Frm_Meses
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
            this.Lbl_Digite = new System.Windows.Forms.Label();
            this.Lbl_2024 = new System.Windows.Forms.Label();
            this.Txt_Digite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_X1
            // 
            this.Btn_X1.BackColor = System.Drawing.Color.Red;
            this.Btn_X1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_X1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_X1.ForeColor = System.Drawing.Color.White;
            this.Btn_X1.Location = new System.Drawing.Point(1020, 12);
            this.Btn_X1.Name = "Btn_X1";
            this.Btn_X1.Size = new System.Drawing.Size(53, 43);
            this.Btn_X1.TabIndex = 1;
            this.Btn_X1.Text = "X";
            this.Btn_X1.UseVisualStyleBackColor = false;
            this.Btn_X1.Click += new System.EventHandler(this.Btn_X1_Click);
            // 
            // Lbl_Digite
            // 
            this.Lbl_Digite.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Digite.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Digite.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Digite.Location = new System.Drawing.Point(68, 229);
            this.Lbl_Digite.Name = "Lbl_Digite";
            this.Lbl_Digite.Size = new System.Drawing.Size(245, 20);
            this.Lbl_Digite.TabIndex = 2;
            this.Lbl_Digite.Text = "Digite o Número Do Mês";
            // 
            // Lbl_2024
            // 
            this.Lbl_2024.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_2024.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_2024.Location = new System.Drawing.Point(175, 337);
            this.Lbl_2024.Name = "Lbl_2024";
            this.Lbl_2024.Size = new System.Drawing.Size(244, 68);
            this.Lbl_2024.TabIndex = 3;
            this.Lbl_2024.Text = "2024";
            this.Lbl_2024.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Digite
            // 
            this.Txt_Digite.Location = new System.Drawing.Point(319, 234);
            this.Txt_Digite.MaxLength = 2;
            this.Txt_Digite.Name = "Txt_Digite";
            this.Txt_Digite.Size = new System.Drawing.Size(205, 20);
            this.Txt_Digite.TabIndex = 1;
            this.Txt_Digite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Digite_KeyPress);
            // 
            // Frm_Meses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Teste.Properties.Resources.Tela_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1085, 630);
            this.Controls.Add(this.Txt_Digite);
            this.Controls.Add(this.Lbl_2024);
            this.Controls.Add(this.Lbl_Digite);
            this.Controls.Add(this.Btn_X1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Meses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Meses_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_X1;
        private System.Windows.Forms.Label Lbl_Digite;
        private System.Windows.Forms.Label Lbl_2024;
        private System.Windows.Forms.TextBox Txt_Digite;
    }
}