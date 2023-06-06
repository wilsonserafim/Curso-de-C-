namespace Formulario
{
    partial class FormSegunda
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
            this.lblTituloSegunda = new System.Windows.Forms.Label();
            this.btnFormMain = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnRetorno = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloSegunda
            // 
            this.lblTituloSegunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSegunda.Location = new System.Drawing.Point(12, 9);
            this.lblTituloSegunda.Name = "lblTituloSegunda";
            this.lblTituloSegunda.Size = new System.Drawing.Size(574, 129);
            this.lblTituloSegunda.TabIndex = 1;
            this.lblTituloSegunda.Text = "Segunda Form";
            this.lblTituloSegunda.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnFormMain
            // 
            this.btnFormMain.Location = new System.Drawing.Point(12, 336);
            this.btnFormMain.Name = "btnFormMain";
            this.btnFormMain.Size = new System.Drawing.Size(129, 38);
            this.btnFormMain.TabIndex = 2;
            this.btnFormMain.Text = "Form Main";
            this.btnFormMain.UseVisualStyleBackColor = true;
            this.btnFormMain.Click += new System.EventHandler(this.btnFormMain_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.Location = new System.Drawing.Point(86, 156);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(441, 44);
            this.txtMensagem.TabIndex = 3;
            // 
            // btnRetorno
            // 
            this.btnRetorno.Location = new System.Drawing.Point(156, 336);
            this.btnRetorno.Name = "btnRetorno";
            this.btnRetorno.Size = new System.Drawing.Size(129, 38);
            this.btnRetorno.TabIndex = 4;
            this.btnRetorno.Text = "Retornar ao Main";
            this.btnRetorno.UseVisualStyleBackColor = true;
            this.btnRetorno.Click += new System.EventHandler(this.btnRetorno_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(291, 336);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(129, 38);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormSegunda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 386);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnRetorno);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.btnFormMain);
            this.Controls.Add(this.lblTituloSegunda);
            this.Name = "FormSegunda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSegunda";
            this.Load += new System.EventHandler(this.FormSegunda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloSegunda;
        private System.Windows.Forms.Button btnFormMain;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnRetorno;
        private System.Windows.Forms.Button btnFechar;
    }
}