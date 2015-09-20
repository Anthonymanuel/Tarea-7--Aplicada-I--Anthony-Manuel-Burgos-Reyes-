namespace Ejercicios
{
    partial class Ejercicio4C6
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
            this.label1 = new System.Windows.Forms.Label();
            this.calificacionListBox = new System.Windows.Forms.ListBox();
            this.menorTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.calcularButton = new System.Windows.Forms.Button();
            this.promedioTextBox = new System.Windows.Forms.TextBox();
            this.mayorTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Calcula el promedio el menor y el mayor con funciones la funciones reciben un par" +
    "ametro tipo jagged";
            // 
            // calificacionListBox
            // 
            this.calificacionListBox.FormattingEnabled = true;
            this.calificacionListBox.Location = new System.Drawing.Point(12, 35);
            this.calificacionListBox.Name = "calificacionListBox";
            this.calificacionListBox.Size = new System.Drawing.Size(721, 95);
            this.calificacionListBox.TabIndex = 18;
            // 
            // menorTextBox
            // 
            this.menorTextBox.Location = new System.Drawing.Point(247, 160);
            this.menorTextBox.Name = "menorTextBox";
            this.menorTextBox.ReadOnly = true;
            this.menorTextBox.Size = new System.Drawing.Size(100, 20);
            this.menorTextBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Menor";
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(302, 221);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(75, 23);
            this.calcularButton.TabIndex = 15;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // promedioTextBox
            // 
            this.promedioTextBox.Location = new System.Drawing.Point(66, 160);
            this.promedioTextBox.Name = "promedioTextBox";
            this.promedioTextBox.ReadOnly = true;
            this.promedioTextBox.Size = new System.Drawing.Size(100, 20);
            this.promedioTextBox.TabIndex = 14;
            // 
            // mayorTextBox
            // 
            this.mayorTextBox.Location = new System.Drawing.Point(457, 160);
            this.mayorTextBox.Name = "mayorTextBox";
            this.mayorTextBox.ReadOnly = true;
            this.mayorTextBox.Size = new System.Drawing.Size(100, 20);
            this.mayorTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mayor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Promedio";
            // 
            // Ejercicio4C6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calificacionListBox);
            this.Controls.Add(this.menorTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.promedioTextBox);
            this.Controls.Add(this.mayorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Ejercicio4C6";
            this.Text = "Ejercicio  4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox calificacionListBox;
        private System.Windows.Forms.TextBox menorTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.TextBox promedioTextBox;
        private System.Windows.Forms.TextBox mayorTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}