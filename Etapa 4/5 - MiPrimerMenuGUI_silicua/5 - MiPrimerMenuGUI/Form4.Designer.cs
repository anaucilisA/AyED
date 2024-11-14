namespace _5___MiPrimerMenuGUI
{
    partial class Form4
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.Dividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(163, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(28, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Menú Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(58, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dividir";
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(175, 172);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(13, 13);
            this.resultado.TabIndex = 13;
            this.resultado.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "=";
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(104, 169);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(46, 20);
            this.text2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "/";
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(33, 169);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(46, 20);
            this.text1.TabIndex = 9;
            // 
            // Dividir
            // 
            this.Dividir.Location = new System.Drawing.Point(67, 211);
            this.Dividir.Name = "Dividir";
            this.Dividir.Size = new System.Drawing.Size(55, 23);
            this.Dividir.TabIndex = 14;
            this.Dividir.Text = "Dividir";
            this.Dividir.UseVisualStyleBackColor = true;
            this.Dividir.Click += new System.EventHandler(this.Dividir_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(253, 332);
            this.Controls.Add(this.Dividir);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Button Dividir;
    }
}