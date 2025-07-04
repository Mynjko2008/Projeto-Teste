
namespace Projeto_Teste
{
    partial class Frm_Peixe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Peixe));
            this.Wmp_Peixe = new AxWMPLib.AxWindowsMediaPlayer();
            this.Timer_Peixe = new System.Windows.Forms.Timer(this.components);
            this.Btn_Pular = new System.Windows.Forms.Button();
            this.Timer_Pular = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Wmp_Peixe)).BeginInit();
            this.SuspendLayout();
            // 
            // Wmp_Peixe
            // 
            this.Wmp_Peixe.Enabled = true;
            this.Wmp_Peixe.Location = new System.Drawing.Point(-3, -4);
            this.Wmp_Peixe.Name = "Wmp_Peixe";
            this.Wmp_Peixe.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Wmp_Peixe.OcxState")));
            this.Wmp_Peixe.Size = new System.Drawing.Size(1049, 681);
            this.Wmp_Peixe.TabIndex = 0;
            // 
            // Timer_Peixe
            // 
            this.Timer_Peixe.Enabled = true;
            this.Timer_Peixe.Interval = 8000;
            this.Timer_Peixe.Tick += new System.EventHandler(this.Timer_Peixe_Tick);
            // 
            // Btn_Pular
            // 
            this.Btn_Pular.Location = new System.Drawing.Point(876, 24);
            this.Btn_Pular.Name = "Btn_Pular";
            this.Btn_Pular.Size = new System.Drawing.Size(80, 33);
            this.Btn_Pular.TabIndex = 1;
            this.Btn_Pular.Text = "Pular";
            this.Btn_Pular.UseVisualStyleBackColor = true;
            this.Btn_Pular.Visible = false;
            this.Btn_Pular.Click += new System.EventHandler(this.Btn_Pular_Click);
            // 
            // Timer_Pular
            // 
            this.Timer_Pular.Enabled = true;
            this.Timer_Pular.Interval = 4000;
            this.Timer_Pular.Tick += new System.EventHandler(this.Timer_Pular_Tick);
            // 
            // Frm_Peixe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 677);
            this.Controls.Add(this.Btn_Pular);
            this.Controls.Add(this.Wmp_Peixe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Frm_Peixe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peixe";
            this.Load += new System.EventHandler(this.Frm_Peixe_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Frm_Peixe_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.Wmp_Peixe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Wmp_Peixe;
        private System.Windows.Forms.Timer Timer_Peixe;
        private System.Windows.Forms.Button Btn_Pular;
        private System.Windows.Forms.Timer Timer_Pular;
    }
}