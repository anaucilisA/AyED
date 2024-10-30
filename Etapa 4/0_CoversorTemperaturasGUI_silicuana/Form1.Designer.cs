namespace _0_CoversorTemperaturasGUI_silicuana
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kel = new System.Windows.Forms.Label();
            this.fa = new System.Windows.Forms.Label();
            this.col = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cal
            // 
            this.cal.Location = new System.Drawing.Point(24, 187);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(75, 23);
            this.cal.TabIndex = 0;
            this.cal.Text = "Calcular";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.cal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-7, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coversor de temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kelvin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fahrenheint";
            // 
            // kel
            // 
            this.kel.AutoSize = true;
            this.kel.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kel.Location = new System.Drawing.Point(217, 127);
            this.kel.Name = "kel";
            this.kel.Size = new System.Drawing.Size(25, 14);
            this.kel.TabIndex = 4;
            this.kel.Text = "0°K";
            // 
            // fa
            // 
            this.fa.AutoSize = true;
            this.fa.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fa.Location = new System.Drawing.Point(217, 144);
            this.fa.Name = "fa";
            this.fa.Size = new System.Drawing.Size(24, 14);
            this.fa.TabIndex = 5;
            this.fa.Text = "0°F";
            // 
            // col
            // 
            this.col.Location = new System.Drawing.Point(12, 141);
            this.col.Name = "col";
            this.col.Size = new System.Drawing.Size(100, 20);
            this.col.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(258, 261);
            this.Controls.Add(this.col);
            this.Controls.Add(this.fa);
            this.Controls.Add(this.kel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label kel;
        private System.Windows.Forms.Label fa;
        private System.Windows.Forms.TextBox col;
    }
}

