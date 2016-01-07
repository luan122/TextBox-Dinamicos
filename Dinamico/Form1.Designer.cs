namespace Dinamico
{
    partial class Caixas_dinamicas
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
            this.btnCriar = new System.Windows.Forms.Button();
            this.txtExistente = new System.Windows.Forms.TextBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txtQuantDel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantCriar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(13, 49);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(75, 23);
            this.btnCriar.TabIndex = 0;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // txtExistente
            // 
            this.txtExistente.Location = new System.Drawing.Point(254, 15);
            this.txtExistente.Name = "txtExistente";
            this.txtExistente.Size = new System.Drawing.Size(100, 20);
            this.txtExistente.TabIndex = 1;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(14, 79);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(75, 23);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.Text = "Deletar textos";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txtQuantDel
            // 
            this.txtQuantDel.Location = new System.Drawing.Point(96, 79);
            this.txtQuantDel.Name = "txtQuantDel";
            this.txtQuantDel.Size = new System.Drawing.Size(52, 20);
            this.txtQuantDel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Quantidade";
            // 
            // txtQuantCriar
            // 
            this.txtQuantCriar.Location = new System.Drawing.Point(96, 53);
            this.txtQuantCriar.Name = "txtQuantCriar";
            this.txtQuantCriar.Size = new System.Drawing.Size(52, 20);
            this.txtQuantCriar.TabIndex = 5;
            // 
            // Caixas_dinamicas
            // 
            this.AcceptButton = this.btnCriar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(401, 343);
            this.Controls.Add(this.txtQuantCriar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantDel);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.txtExistente);
            this.Controls.Add(this.btnCriar);
            this.Name = "Caixas_dinamicas";
            this.Text = "Caixas de texto dinamicas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.TextBox txtExistente;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.TextBox txtQuantDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantCriar;
    }
}

