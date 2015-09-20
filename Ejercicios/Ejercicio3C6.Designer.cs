namespace Ejercicios
{
    partial class Ejercicio3C6
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mayorTextBox = new System.Windows.Forms.TextBox();
            this.promedioTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.menorTextBox = new System.Windows.Forms.TextBox();
            this.calificacionListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Promedio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mayor";
            // 
            // mayorTextBox
            // 
            this.mayorTextBox.Location = new System.Drawing.Point(455, 153);
            this.mayorTextBox.Name = "mayorTextBox";
            this.mayorTextBox.ReadOnly = true;
            this.mayorTextBox.Size = new System.Drawing.Size(100, 20);
            this.mayorTextBox.TabIndex = 4;
            // 
            // promedioTextBox
            // 
            this.promedioTextBox.Location = new System.Drawing.Point(64, 153);
            this.promedioTextBox.Name = "promedioTextBox";
            this.promedioTextBox.ReadOnly = true;
            this.promedioTextBox.Size = new System.Drawing.Size(100, 20);
            this.promedioTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Menor";
            // 
            // menorTextBox
            // 
            this.menorTextBox.Location = new System.Drawing.Point(245, 153);
            this.menorTextBox.Name = "menorTextBox";
            this.menorTextBox.ReadOnly = true;
            this.menorTextBox.Size = new System.Drawing.Size(100, 20);
            this.menorTextBox.TabIndex = 8;
            // 
            // calificacionListBox
            // 
            this.calificacionListBox.FormattingEnabled = true;
            this.calificacionListBox.Location = new System.Drawing.Point(10, 28);
            this.calificacionListBox.Name = "calificacionListBox";
            this.calificacionListBox.Size = new System.Drawing.Size(721, 95);
            this.calificacionListBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Calcula el promedio el menor y el mayor";
            // 
            // Ejercicio3C6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calificacionListBox);
            this.Controls.Add(this.menorTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.promedioTextBox);
            this.Controls.Add(this.mayorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Ejercicio3C6";
            this.Text = "Ejercicio 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mayorTextBox;
        private System.Windows.Forms.TextBox promedioTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox menorTextBox;
        private System.Windows.Forms.ListBox calificacionListBox;
        private System.Windows.Forms.Label label1;
    }
}