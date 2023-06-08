﻿namespace Formulario
{
    partial class FormMain
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSegunda = new System.Windows.Forms.Button();
            this.btnSegundaThread = new System.Windows.Forms.Button();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mFileSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpSobreDes = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpSobreVer = new System.Windows.Forms.ToolStripMenuItem();
            this.comboMenu = new System.Windows.Forms.ToolStripComboBox();
            this.mPesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(13, 93);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(574, 129);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Principal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSegunda
            // 
            this.btnSegunda.Location = new System.Drawing.Point(17, 334);
            this.btnSegunda.Name = "btnSegunda";
            this.btnSegunda.Size = new System.Drawing.Size(124, 40);
            this.btnSegunda.TabIndex = 1;
            this.btnSegunda.Text = "Segunda Form";
            this.btnSegunda.UseVisualStyleBackColor = true;
            this.btnSegunda.Click += new System.EventHandler(this.btnSegunda_Click);
            // 
            // btnSegundaThread
            // 
            this.btnSegundaThread.Location = new System.Drawing.Point(143, 334);
            this.btnSegundaThread.Name = "btnSegundaThread";
            this.btnSegundaThread.Size = new System.Drawing.Size(124, 40);
            this.btnSegundaThread.TabIndex = 2;
            this.btnSegundaThread.Text = "Segunda Form Thread";
            this.btnSegundaThread.UseVisualStyleBackColor = true;
            this.btnSegundaThread.Click += new System.EventHandler(this.btnSegundaThread_Click);
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp,
            this.comboMenu,
            this.mPesquisar});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(599, 27);
            this.menuBar.TabIndex = 3;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileNovo,
            this.mFileAbrir,
            this.toolStripSeparator1,
            this.mFileSair});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 23);
            this.menuFile.Text = "File";
            // 
            // mFileNovo
            // 
            this.mFileNovo.Name = "mFileNovo";
            this.mFileNovo.Size = new System.Drawing.Size(180, 22);
            this.mFileNovo.Text = "Novo";
            // 
            // mFileAbrir
            // 
            this.mFileAbrir.Name = "mFileAbrir";
            this.mFileAbrir.Size = new System.Drawing.Size(180, 22);
            this.mFileAbrir.Text = "Abrir";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mFileSair
            // 
            this.mFileSair.Name = "mFileSair";
            this.mFileSair.Size = new System.Drawing.Size(180, 22);
            this.mFileSair.Text = "Sair";
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpSobre});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(44, 23);
            this.menuHelp.Text = "Help";
            // 
            // mHelpSobre
            // 
            this.mHelpSobre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpSobreDes,
            this.mHelpSobreVer});
            this.mHelpSobre.Name = "mHelpSobre";
            this.mHelpSobre.Size = new System.Drawing.Size(180, 22);
            this.mHelpSobre.Text = "Sobre";
            // 
            // mHelpSobreDes
            // 
            this.mHelpSobreDes.Name = "mHelpSobreDes";
            this.mHelpSobreDes.Size = new System.Drawing.Size(180, 22);
            this.mHelpSobreDes.Text = "Desenvolvedor";
            // 
            // mHelpSobreVer
            // 
            this.mHelpSobreVer.Name = "mHelpSobreVer";
            this.mHelpSobreVer.Size = new System.Drawing.Size(180, 22);
            this.mHelpSobreVer.Text = "Versão";
            // 
            // comboMenu
            // 
            this.comboMenu.Items.AddRange(new object[] {
            "Inglês",
            "Português"});
            this.comboMenu.Name = "comboMenu";
            this.comboMenu.Size = new System.Drawing.Size(121, 23);
            // 
            // mPesquisar
            // 
            this.mPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mPesquisar.Name = "mPesquisar";
            this.mPesquisar.Size = new System.Drawing.Size(100, 23);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 386);
            this.Controls.Add(this.btnSegundaThread);
            this.Controls.Add(this.btnSegunda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSegunda;
        private System.Windows.Forms.Button btnSegundaThread;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem mFileNovo;
        private System.Windows.Forms.ToolStripMenuItem mFileAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mFileSair;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem mHelpSobre;
        private System.Windows.Forms.ToolStripMenuItem mHelpSobreDes;
        private System.Windows.Forms.ToolStripMenuItem mHelpSobreVer;
        private System.Windows.Forms.ToolStripComboBox comboMenu;
        private System.Windows.Forms.ToolStripTextBox mPesquisar;
    }
}

