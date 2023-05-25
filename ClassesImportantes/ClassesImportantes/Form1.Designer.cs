namespace ClassesImportantes
{
    partial class Form1
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
            this.btnMessengeBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMessengeBox
            // 
            this.btnMessengeBox.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btnMessengeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMessengeBox.Location = new System.Drawing.Point(12, 381);
            this.btnMessengeBox.Name = "btnMessengeBox";
            this.btnMessengeBox.Size = new System.Drawing.Size(223, 57);
            this.btnMessengeBox.TabIndex = 0;
            this.btnMessengeBox.Text = "MSGBOX";
            this.btnMessengeBox.UseVisualStyleBackColor = true;
            this.btnMessengeBox.Click += new System.EventHandler(this.btnMessengeBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMessengeBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMessengeBox;
    }
}

